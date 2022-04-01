# Python 3.6.9
# Moein Sharifi Moghaddam
#T00665076
#Comp 2211 Assignment 2
#this application is a basic password and username genera

#receives data of first, last name and id by the user and returns a UserID
def get_login_name (first, last, id) :

    
    first = first[0 : 3]
    last = last [0 : 3]
    id = id[len(id) - 3 : len(id)]
    user_name = first + last + id

    return user_name

#Veryfies the password requested by the user meet the criteria
#returns true if it meets crieteria and false if it does not
def verify_password (password) : 

    bool_password = True
    lower_count = 0
    upper_count = 0
    degit_count = 0
    space_count = 0

    if (len(password) < 7): 
        bool_password = False 
    else: 
        for char in password:

            if (char.islower() == True): 
                lower_count += 1
            elif (char.isupper() == True): 
                upper_count += 1
            elif (char.isdigit() == True): 
                degit_count += 1
            elif (char.isspace() == True):
                space_count += 1

        if (not (degit_count >= 1 and upper_count >=1 and lower_count >=1 and space_count < 1 )): 
            bool_password = False

    return bool_password

def main () : 

    bool_control = True
    #handles user process of creating a user name
    while (bool_control == True):
        print("Enter Your First Name: ")
        first_name = str(input()) 
        print("Enter Your Last Name: ")
        last_name = str(input())
        print("Enter Your Student ID: ")
        student_id = str(input())
        print("\n\n----------")
        first_name = first_name.replace(" ", "")      
        last_name = last_name.replace(" ", "")
        student_id = student_id.replace(" ", "")

        first_name = first_name.replace("\n", "")      
        last_name = last_name.replace("\n", "")
        student_id = student_id.replace("\n", "")

        first_name = first_name.replace("\t", "")      
        last_name = last_name.replace("\t", "")
        student_id = student_id.replace("\t", "")

       
        bool_control = False

        bool_input_isempty = len(first_name) == 0 or len(last_name) == 0 or len(student_id) == 0
        if (bool_input_isempty == True): 
            print("Information entered for at least of the fields is empty")
            bool_control = True
        if (first_name.isalpha() == False or last_name.isalpha() == False ):
            print("First name or Last name should contain letters only")
            bool_control = True
        if (student_id.isdigit() == False): 
            print("Student ID should only contain digits'")
            bool_control = True
        print("\n\n-------------")

    
    login_name = get_login_name(first_name, last_name, student_id)


    
    
    bool_password_condition = False
    #handles user creation of a valid password 
    while(bool_password_condition == False):
        print ("Please Enter a Password. The password must be: ")
        print ("At least 7 character \nHas one upper case, one lower case and one degit")
        password = str(input())
        print("\n\n----------")
        bool_password = verify_password(password)

        if (bool_password == True): 
            print("Your Password matches conditions")
            bool_password_condition = True
        else: 
            print("The Password Entered Does not Meet the Condition")
            bool_password_condition = False

    print("Your Generated Login Name is: " + login_name)
    print("Your Generated Password is: " + password)
    
main() 