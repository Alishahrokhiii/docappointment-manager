import Payment
listpatient=[]
listreservation=[]
class PatientFile:

    def __init__(self):
        self._fname = ""
        self._lname = ""
        self._phone = ""
        self._code = ""


    def setup(self):
        print ("Setting up the Patient")
        fname = input("please enter first name of patient:")
        lname = input("please enter last name of patient:")
        phone = input("please enter phone of patient:")
        code = input("please enter meli code of patient:")
        listpatient.append([fname,lname,phone,code])
        self._am.publishpatientReport()

    def reservetime(self):
        patientmelicode=input("please enter patient melicode")
        ch=False
        for p in listpatient:
            if p[3]==patientmelicode:
                self=p
                ch=True
        if not ch:
            print("melicode not found!")
            return

        date=input("please enter date for appoitment(yyyy/mm/dd):")
        hour = input("please enter date for appoitment(hh between 9:00 to 14:00):")
        ch=True
        for reserve in listreservation:
            if reserve[0]==date and reserve[1]==hour :
                print("Your Request Time is busy.")
                ch=False
        if ch:
            choose=input("please choose bank gateway Mellat :m , Passargad :p ")
            gateway=Payment.Payment()
            price=0
            if choose=='p':
                passargad = Payment.Pasargad()
                price=passargad.preparePay()
            else:
                mellat = Payment.Melat()
                price=mellat.preparePay()

            listreservation.append([date,hour,self,price,''])
        # self._am.publishreservationReport()
    def appointment(self):
        patientmelicode = input("please enter patient melicode")
        ch = False
        for p in listpatient:
            if p[3] == patientmelicode:
                ch = True
        if not ch:
            print("melicode not found!")
            return

        date = input("please enter date for appoitment(yyyy/mm/dd):")
        hour = input("please enter date for appoitment(hh between 9:00 to 14:00):")
        ch = True
        for reserve in listreservation:
            if reserve[0] == date and reserve[1] == hour:
                docotorAdcie = input("please enter Doctor advice:")
                reserve[4]=docotorAdcie
                ch = False
        if ch:
            print("your date and time is wrong.")





    def setAM(self,am):
        self._am = am


class Reporter:

    def __init__(self):
        self._am = None

    def listofreservartion(self):
        print("Reporter Create List of All Reservations")
        date=input("please enter date for appoitment(yyyy/mm/dd) or type 0 for list all for all day :")
        c=0
        for r in listreservation:
            if date=='0' or r[0]==date:
                print("Resrvation #",c," At Date: "+r[0]+" Hour: "+r[1]+" with price: "+r[3]+" Doctor Advice: "+r[4])
                print("Patient : [firstname: " + r[2][0] + " lastname: " +
                      r[2][1] + " phone: " +
                      r[2][2] + " melicode: " + r[2][3] + "]")
                c+=1


    def listofpatient(self):
        print ("List of All patients")
        c=1
        for p in listpatient:
            print("Patient ",c," [firstname: " + p[0] + " lastname: " +
                  p[1]+ " phone: " +
                  p[2]+ " melicode: " + p[3]+ "]")
            c+=1

    def setAM(self,am):
        self._am = am

class AppointmentManagement: #Mediator Between Other Classes

    def __init__(self):
        self._reporter = None
        self._pateitn = None



    def setReporter(self, reporter):
        self._reporter = reporter

    def setpatient(self, patient):
        self._pateitn=patient

    def publishpatientReport(self):
        self._reporter.listofpatient()

    def publishreservationReport(self):
        self._reporter.listofreservartion()

    def registernewpatient(self):
        self._pateitn.setup()

    def registernewreservation(self):
        self._pateitn.reservetime()

    def appointment(self):
        self._pateitn.appointment()
