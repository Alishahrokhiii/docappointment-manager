import login
import app_management
import sys


auth = login.Authentication()
am= app_management.AppointmentManagement()
p=app_management.PatientFile()
r=app_management.Reporter()

while(True):
    while(not auth.validate()):
        auth.login()

    am.setpatient(p)
    am.setReporter(r)
    p.setAM(am)
    r.setAM(am)

    while(True):
        menu=input("Enter your job: \n"
                   "p: for register pateient\n"
                   "r: for reserve time to appointment\n"
                   "a: for implement a appointment by doctor\n"
                   "lp: for list of all patient\n"
                   "lr: for list of all reservation\n"
                   "o: for logout\n"
                   "q: for Quit")
        if menu=='p':
            am.registernewpatient()
        elif menu=='r':
            am.registernewreservation()
        elif menu=='a':
            am.appointment()
        elif menu=='lp':
            am.publishpatientReport()
        elif menu=='lr':
            am.publishreservationReport()
        elif menu=='o':
            auth.logout()
            break
        elif menu=='q':
            sys.exit(1)




