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
                Console.WriteLine("Enter an option :");
                Console.WriteLine("1. Add a To Do ");
                Console.WriteLine("2. Update a To Do");
                Console.WriteLine("3. Display all your Tasks");
                Console.WriteLine("4 Exit");
                //Get user input;
                var userInput = Int32.Parse(Console.ReadLine());
                //Create a new method contains all the functionalities
                var dailyTodo =new functions();
                while (true){
                    switch(userInput){
                        case 1:
                            Console.WriteLine("Enter your task:");
                            var task = Console.ReadLine();
                            var newToDo= new ToDo(task);
                            dailyTodo.AddTask(newToDo);
                            break;
                        case 2:
                            Console.WriteLine("Enter the index of the task you want to update:");
                            var taskIndex= Int32.Parse(Console.ReadLine());
                            if(taskIndex>0 && taskIndex<dailyTodo.totalNumberOfTasks()){
                                Console.WriteLine("Have you completed the task:");
                                Console.WriteLine("1. Yes   2. No");
                                var completed = Int32.Parse(Console.ReadLine());
                                if(completed == 1){
                                    dailyTodo.UpdateToDo(taskIndex-1,"Yes");
                                }
                                else if(completed == 2){
                                    dailyTodo.UpdateToDo(taskIndex-1, "No");
                                }
                                else{
                                    Console.WriteLine("Please enter a valid input");
                                }
                            }
                            break;
                        case 3:
                            dailyTodo.DisplayAllTasks();
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Please enter a value");
                            break;
                }
                Console.WriteLine("Enter option :");
                Console.WriteLine("1. Add a To Do ");
                Console.WriteLine("2. Update a To Do");
                Console.WriteLine("3. Display a To Do");
                Console.WriteLine("4 Exit");
                userInput = Int32.Parse(Console.ReadLine());
            }   
            }
            catch (System.Exception)
            {
                Console.WriteLine("An error occured with your input.");
            }
            
        }
    }
}
