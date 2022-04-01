# Python 3.6.9
# Moein Sharifi Moghaddam
#T00665076
#Comp 2211 Assignment 3
#this application is a basic password and username genera

def main(): 

    valid = []
    valid_restricted = []
    invalid = []
    #open file to read
    str_file = open('A3 Codes.txt', 'r')
    #reads through text line by line
    for str_one in str_file.readlines(): 
        #deletes new lines in each line
        str_one = str_one.strip()
        #returns and saves digits containing country code
        str_country_code = str_one[3:7]  
        #checks if the code length is at least 10, country code is valid and security of product is valid
        if(len(str_one) < 10 or str_country_code.isdigit() == False or str_one[9].isupper() == False ) : 
            #adds them to the list of invalid product if criterias are not met
            invalid.append(str_one)
        else: 
            #cheks the validated procuct are restricted or not and place them into their own category
            if(int(str_country_code) >= 2000 and str_one[9] == 'R'): 
                valid_restricted.append(str_one)
            else: 
                valid.append(str_one)
    #finished reading file and closes the file
    str_file.close()
    #Print the results of each category (valid, restricted valid and invalid)
    print ("\nValid Code(s) are:\n")
    for str_index in valid:
        print(str_index)
    print ("\nValid Restricted Code(s) are:\n")
    for str_index in valid_restricted: 
        print(str_index)
    print ("\nInvalid Code(s) are:\n")
    for str_index in invalid: 
        print(str_index)
            
main()