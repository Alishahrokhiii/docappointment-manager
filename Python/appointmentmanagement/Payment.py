price=0
class Payment:

    def preparePay(self):
        self.getprice()
        self.setbankconfig()
        return self.pay()

    def getprice(self):
        global price
        price=input("please enter price of reservation:")


    def setbankconfig(self):
        pass

    def pay(self):
        pass


class Melat(Payment):

    def setbankconfig(self):
        print("setting bank config for connection to bank")

    def pay(self):
        print("Bank ok! "+price+" Payed Successful to Mellat Gateway")
        return price

class Pasargad(Payment):

    def setbankconfig(self):
        print("setting bank config for connection to bank")

    def pay(self):
        print("Bank ok! "+price+" Payed Successful to Passargad Gateway")
        return price

