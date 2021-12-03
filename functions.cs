using System;
using System.Collections.Generic;
using System.Linq;

namespace task1
{
    class functions{
        private List<ToDo> _todo {get;set;} = new List<ToDo>();


        //Update a particular task when you have completed it.
        private void updateTask(List<ToDo> ToDo,int index,string completed){
           for(var i=0;i<ToDo.Count;i++){
               if(index==i){
                   ToDo[index].Completed=completed;
                   ToDo[index].timeUpdated=DateTime.Now;
                   break;
               }
           }
        }
        //Show all the tasks 
        private void DisplayTodo(List<ToDo> ToDo){
            if(ToDo.Count==0){
                Console.WriteLine("Nothing to display");
            }else{
                for(var i=0;i<ToDo.Count;i++){
                if(ToDo[i].Completed=="Yes"){
                    Console.WriteLine($"{i+1}. Task:{ToDo[i].Task},Completed:{ToDo[i].Completed},timeCreated:{ToDo[i].GetDateTimeOfCreated()}, timeUpdated:{ToDo[i].GetDateTimeOfUpdated()}");
                }
                else{
                    Console.WriteLine($"{i+1}. Task:{ToDo[i].Task},Completed:{ToDo[i].Completed},timeCreated:{ToDo[i].GetDateTimeOfCreated()}, timeUpdated:");
                }
            }
            }
        }
        //Counts the number of tasks in your daily to do
        private int TodoListCounts(List<ToDo> toDos){
            return toDos.Count;
        }
        //Add a new task to your daily todo 
        public void AddTask(ToDo toDo){
            _todo.Add(toDo);
            
        }

        //Display options to the users
        public void DisplayOptions(){
                Console.WriteLine("1. Add a To Do ");
                Console.WriteLine("2. Update a To Do");
                Console.WriteLine("3. Display all your Tasks");
                Console.WriteLine("4 Exit");
        }
        //Get the total number of tasks in the todo
        public int totalNumberOfTasks(){
            return TodoListCounts(_todo);
        }
        public void DisplayAllTasks(){
            DisplayTodo(_todo);
        }
        public void UpdateToDo(int index,string completed){
            updateTask(_todo,index,completed);
        }
        
    }
}