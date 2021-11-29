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
                   ToDo[index].GetDateTimeOfUpdated(1);
                   break;
               }
           }
        }
        //Show all the tasks 
        private void DisplayTodo(List<ToDo> ToDo){
            for(var i=0;i<ToDo.Count;i++){
                if(ToDo[i].Completed=="Yes"){
                    Console.WriteLine($"{i+1}. Task:{ToDo[i].Task},Completed:{ToDo[i].Completed},timeCreated:{ToDo[i].GetDateTimeOfCreated()}, timeUpdated:{ToDo[i].GetDateTimeOfUpdated(1)}");
                }
                else{
                    Console.WriteLine($"{i+1}. Task:{ToDo[i].Task},Completed:{ToDo[i].Completed},timeCreated:{ToDo[i].GetDateTimeOfCreated()}, timeUpdated:{ToDo[i].GetDateTimeOfUpdated()}");
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