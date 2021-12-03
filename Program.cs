using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {       
            try
            {
                Console.WriteLine("<< TODO APP >>");
                //Create a new method contains all the functionalities
                var dailyTodo =new functions();
                Console.WriteLine("Enter an option :");
                dailyTodo.DisplayOptions();
                //Get user input;
                var userInput = Console.ReadLine();
                //validates userinput
                while(true){
                    int validUserInput;
                    //Check if the inpput is an integer
                    if(!Int32.TryParse(userInput, out validUserInput)){
                        Console.WriteLine("Input must be a valid integer");
                    }
                    //Check if the input is a valid option
                    else if(validUserInput>4 || validUserInput<1){
                        Console.WriteLine("Input must be from the following options.");
                    }
                    //Add a To Do
                    else if(validUserInput==1){
                        int validTask;
                        Console.WriteLine("Enter your task:");
                        var task = Console.ReadLine();
                        // Validation
                        // 1.) Check if the user input is not empty 
                        while(string.IsNullOrEmpty(task)){
                            Console.WriteLine("Your task cannot be empty!!");
                            Console.WriteLine("Enter your task:");
                            task= Console.ReadLine();
                        }
                        // 2.) Check if the user input is a valid string
                        while(Int32.TryParse(task,out validTask)){
                            Console.WriteLine("Only String Characters are allowed");
                            Console.WriteLine("Enter your task:");
                            task= Console.ReadLine();
                        }
                        var newToDo= new ToDo(task);
                        dailyTodo.AddTask(newToDo);
                    }
                    //Update your To Do
                    else if(validUserInput==2){
                        Console.WriteLine("Enter the index of the task you want to update:");
                        int validTaskIndex;
                        var taskIndex= Console.ReadLine();
                        //Check if the index of the task to be updated is an integer
                        while(!Int32.TryParse(taskIndex,out validTaskIndex)){
                            Console.WriteLine("Sorry enter a valid task index:");
                            taskIndex= Console.ReadLine();
                        }
                        //Check if the index of the task to be updated is within context
                        while(validTaskIndex<0 || validTaskIndex>dailyTodo.totalNumberOfTasks()){  
                            Console.WriteLine("Sorry, the task with that index does not exist,!!!");
                            taskIndex=Console.ReadLine();                          
                        }
                        Console.WriteLine("Have you completed the task:");
                        Console.WriteLine("1. Yes   2. No");
                        int validResponse;
                        var response =Console.ReadLine();
                        //Validates the user input to get a 
                        while(!Int32.TryParse(response,out validResponse)){
                            Console.WriteLine("Please specify with either 1(yes) or 2(No):");
                            Console.ReadLine();
                        }
                        while(validResponse!= 1 && validResponse!=2){
                            Console.WriteLine("Please specify with either 1(yes) or 2(No)");
                            Console.ReadLine();
                        }
                        if(validResponse == 1){
                                 dailyTodo.UpdateToDo(validTaskIndex-1,"Yes");
                            }
                            else if(validResponse == 2){
                                dailyTodo.UpdateToDo(validTaskIndex-1, "No");
                            }
                    }
                    //Display your ToDo
                    else if(validUserInput== 3){
                        dailyTodo.DisplayAllTasks();
                    }
                    //Exit the program
                    else if(validUserInput== 4){
                        return;
                    }
                    dailyTodo.DisplayOptions();
                    userInput = Console.ReadLine();
                }
            
            }
            catch (OutOfMemoryException Error)
            {
                
                Console.WriteLine($"An Error Occured:{Error}");
            }
                
        }
    }
}
