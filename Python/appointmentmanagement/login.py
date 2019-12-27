check = False
user_pass=[['user1','pass1'],['user2','pass2']]
class State:

    def login(self):
        pass

    def logout(self):
        pass

class LoginState(State):

    def logout(self):
        global check
        check=False
        print("...logout!!!")
        return LogoutState()


class LogoutState(State):

    def login(self):
        global check
        username = input("please enter username:")
        password = input("please enter password:")
        for up in user_pass:
            if up[0] == username and up[1] == password:
                check=True
        if not check:
            print("Please enter correct username and password")
            return self
        else:
            print("login sucsessful")
            return LoginState()



class Authentication:
    def __init__(self):
        self.loginstate = LoginState()
        self.logoutstate = LogoutState()
        self.state = self.logoutstate

    def login(self):
        self.state=self.state.login()


    def logout(self):
        self.state.logout()
        self.state = self.logoutstate

    def validate(self):
        return check


# auth = Authentication()
# auth.login()
# print("check for login is:",auth.validate())
# auth.logout()
# print("check for login is:",auth.validate())