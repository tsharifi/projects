    /******************************************************************************
    
                                Online C Compiler.
                    Code, Compile, Run and Debug C program online.
    Write your code in this editor and press "Run" button to compile and execute it.
    
    *******************************************************************************/
    
    #include <stdio.h>
    #include <string.h>
    #include <stdlib.h>
    
    typedef struct student {
        
        char student_id[50], name[50], email[50], course_id[50], grade[50]; 
    } Student; 
    
    // prints the menu options of action to choose from
    void display_menu(){
       printf("         M A I N  M E N U\n"); 
       printf("1. Create the Binary File\n");
       printf("2. Display the contents of the file\n");
       printf("3. Seek a specific record\n");
       printf("4. Update the contents of a record\n");
       printf("5. Delete a record for the specific name\n");
       printf("6. Exit\n\n");
       printf("       Please Enter your choice .... ");
    }
    
    // update number elements in binary file
    void update_count(int *count){
        
        Student std; 
        FILE *f; 
        f = fopen("Student_Records.bin", "rb");
        if(f == NULL){
            printf(".... File is Empty ....\n"); 
            *count = 0; 
        } else {
            *count = 0; 
            while(fread(&std, sizeof(std), 1, f)){
                (*count)++; 
            }
        }
        fclose(f); 
    }
    
    int main()
    {
        int user_choice; 
        Student student; 
        int count = 0; // keeps track of number of student record on the binary file 
        int found; 
        FILE *file; 
    
        while (user_choice != 6){
            
            display_menu(); 
            scanf("%d", &user_choice); 
            
            if(user_choice == 1){
                printf("Enter number of student records to add .... "); 
                int num_record; 
                scanf("%d", &num_record); 
                
                // dynamically allocate memory based on user number of record choice 
                Student *pointer = (Student*) calloc(num_record, sizeof(Student)); 
                
                // write user input of each student record into the binary file
                for(int i = 0; i < num_record; i++){
                    Student temp;  
                    printf("         Student Record number %d of %d to add \n", i + 1, num_record); 
                    printf("Student ID: "); 
                    scanf("%s", temp.student_id); 
                    printf("Student Name: "); 
                    scanf("%s", temp.name); 
                    printf("Email ID: "); 
                    scanf("%s", temp.email); 
                    printf("Course ID: "); 
                    scanf("%s", temp.course_id);
                    printf("Grade: "); 
                    scanf("%s", temp.grade); 
                    pointer[i] = temp; 
                    count++; 
                }
                file = fopen("Student_Records.bin", "ab"); 
                fwrite(pointer, sizeof(Student), num_record, file); 
                fclose(file); 
                free(pointer); 
                
            } else if (user_choice ==2){
                
                // print the content of the binary file
                file = fopen("Student_Records.bin", "rb");
                int index = 1;
                printf("\n"); 
                int *temp; 
                temp = &count; 
                update_count(temp); 
                
                while(fread(&student, sizeof(student), 1, file)){
                    printf("\n         STUDENT RECORD %d of %d\n", index, count);
                    printf("         ---------------------\n");
                    printf("Student ID: %s\n", student.student_id);
                    printf("Student Name: %s\n", student.name);
                    printf("Email ID: %s\n", student.email);
                    printf("Course ID: %s\n", student.course_id);
                    printf("Student Grade: %s\n", student.grade);
                    index++; 
                }
                printf("\n"); 
                fclose(file); 
                
            } else if (user_choice == 3){
                
                printf("\nEnter the Student ID You Want to Search .... "); 
                char id[50]; 
                scanf("%s", id); 
        
                found = 0; 
                file = fopen("Student_Records.bin", "rb");
                // check the binary file for the record base on Student ID
                while(fread(&student, sizeof(student), 1, file)){
                    if(strcmp(id, student.student_id) == 0){
                        found = 1; 
                        printf("         RECORD FOUND\n\n"); 
                        printf("Student ID: %s\n", student.student_id);
                        printf("Student Name: %s\n", student.name);
                        printf("Email ID: %s\n", student.email);
                        printf("Course ID: %s\n", student.course_id);
                        printf("Student Grade: %s\n", student.grade);
                        break;
                    }
                }
                fclose(file); 
                if(found == 0){
                    printf("The Student Record Not Found\n"); 
                }
                
            } else if (user_choice == 4){
                
                printf("Please Enter the Student ID to Update .... "); 
                char temp[50]; 
                scanf("%s", temp); 
                printf("\n"); 
                
                int *temp_count = &count; 
                update_count(temp_count); 
                printf("%d", count); 
                Student *ptr = (Student*) calloc(count, sizeof(Student)); 
                file = fopen("Student_Records.bin", "rb"); 
                found = 0; 
                int index = 0; 
                Student std_temp; 
                
                while(fread(&student, sizeof(student), 1, file)){
                    
                    if(strcmp(temp, student.student_id) == 0){
                        printf("         Record Found Base on Student ID\n");
                        printf("         -------------------------------\n");
                        printf("1. Student ID: %s\n", student.student_id);
                        printf("2. Student Name: %s\n", student.name);
                        printf("3. Email ID: %s\n", student.email);
                        printf("4. Course ID: %s\n", student.course_id);
                        printf("5. Student Grade: %s\n", student.grade);
                        printf("----------------------------------------\n");
                        printf("         Please select from 1-5 Which Category You Want to Update .... "); 
                        
                        std_temp= student; 
                        int category;
                        scanf("%d", &category); 
                        printf("\n");
                        if(category == 1){
                            
                            printf("\n"); 
                            printf("          Enter the New Student Name .... "); 
                            scanf("%s", std_temp.student_id);
                        } else if (category == 2){
                
                            printf("\n"); 
                            printf("          Enter the New Name .... "); 
                            scanf("%s", std_temp.name); 
                        } else if (category == 3) {
                            
                            printf("\n"); 
                            printf("          Enter the New Email ID .... "); 
                            scanf("%s", std_temp.email); 
                        } else if (category == 4){
                            
                            printf("\n"); 
                            printf("          Enter the New Course ID .... "); 
                            scanf("%s", std_temp.course_id);     
                        } else if (category == 5){
                            
                            printf("\n"); 
                            printf("          Enter the New Grade .... "); 
                            scanf("%s", std_temp.grade);   
                        } else {
                            printf("\nYour Category Selection is Invalid\n");
                        }
                        found = 1; 
                        student = std_temp; 
                    }
                    ptr[index] = student; 
                    index++;
                }
                fclose(file); 
                
                file = fopen("Student_Records.bin", "wb");
                fwrite(ptr, sizeof(Student), count, file); 
                fclose(file); 
                free(ptr); 
                
                if(found == 0){
                    printf("         Student ID not Found in Database\n"); 
                }
                
            } else if (user_choice == 5){
                
                printf("\n Enter the Name of The Student to Delete .... "); 
                char delete_str[50]; 
                scanf("%s", delete_str); 
                
                //update number of student records in binary file student records and allocation dynamic memory
                int *temp = &count; 
                update_count(temp); 
    
                // search the binary file by name
                file = fopen("Student_Records.bin", "rb");
                found =0;
                int index = 0; 
                Student *ptr = (Student*) calloc(count, sizeof(Student)); 
                
                // save all student records into a dynamic memory 
                while(fread(&student, sizeof(student), 1, file)){
                    ptr[index] = student; 
                    index++; 
                }
                fclose(file); 
                
                // write records from dynamic memory into another temporary dynamic memory with currect size after deletion
                file = fopen("Student_Records.bin", "wb");
                Student *temp_ptr = (Student*) calloc(count, sizeof(Student));
                int temp_count = count; 
                for(int i = 0; i < count; i++){
                    
                    if(strcmp(delete_str, ptr[i].name) == 0){
                        temp_ptr = (Student*) realloc(temp_ptr, temp_count - 1); 
                        temp_count--; 
                    } 
                }
                
                int j = 0; 
                for(int i = 0; i < count; i++){
                    
                    if(strcmp(delete_str, ptr[i].name) != 0){
                        temp_ptr[j] = ptr[i]; 
                        j++; 
                    }
                }
                
                fwrite(temp_ptr, sizeof(Student), temp_count, file);
                fclose(file);
                free(ptr); 
                free(temp_ptr); 
    
            } else {
                if(user_choice == 6){
                    break; 
                } else {
                    printf("Invalid choice Enter, Try again\n");
                    printf("-------------------------------\n\n"); 
                }
            }
        }
    
        return 0;
    }