
#student number : T00665076
#name: Moein Sharifi Moghaddam



#iport math module 
import math


# Gets present value, interest rate and number of months from the user. 
def getUserCalculationInfo () : 

    print("Enter Present Value of Account: ")
    x = float(input()) 
    
    print ("Enter Monthly Interest Rate: ")
    y= float (input()) * 0.01

    print("Enter Number of Months: ")
    z= int (input())

    return x, y, z 


# Calculate future value of account
def calculate_future_value (p, i, t) :

    future_value = ((1 + i) ** t) * p 
    return future_value 
    

# print future value to the screen. 
def print_future_value (f) : 
    

    if f > (int(f) + 0.50) : 

        f = int(math.ceil(f))

    elif f < (int(f) + 0.50) : 

        f = int(math.floor(f))

    elif f == (int(f) + 0.50) : 

        f = int(f) + 0.50

    
    print ("Account Future Value is $" + str(f) )



def main () :

    # get user information of account
    P, I, T = getUserCalculationInfo()

    #calculate future value
    F = calculate_future_value (P, I, T) 

    #print future value
    print_future_value (F)
    

main()