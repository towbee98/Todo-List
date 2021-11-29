using System;
using System.Collections.Generic;
using System.Text;

namespace task1{
    class ToDo{
        // protected int index;
        protected DateTime timeCreated= DateTime.Now;
        protected DateTime timeUpdated;
        //Constructor
        public ToDo(string todo,string completed="No"){
            Task= todo;
            Completed=completed;
        }
        public string Task{get;set;}
        public string Completed{get;set;}

        // public int getIndex(){
        //     return index;
        // }
        public DateTime GetDateTimeOfCreated(){
            return timeCreated;
        }
        public DateTime? GetDateTimeOfUpdated(int update=0){
            if(update==0){
                DateTime? newTimeUpdated=null;
                return newTimeUpdated;
            }
            return timeUpdated=DateTime.Now;
             

        }
    }
}