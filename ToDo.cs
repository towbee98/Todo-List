using System;
using System.Collections.Generic;
using System.Text;

namespace task1{
    class ToDo{
        private int id=0;
        // protected int index;
        protected DateTime timeCreated= DateTime.Now;
        //Constructor
        public ToDo(string todo,string completed="No"){
            id++;
            Task= todo;
            Completed=completed;
        }
        public string Task{get;set;}
        public string Completed{get;set;}
        public DateTime timeUpdated{get;set;}
        // public int getIndex(){
        //     return index;
        // }
        public DateTime GetDateTimeOfCreated(){
            return timeCreated;
        }
        public DateTime GetDateTimeOfUpdated(){
            return timeUpdated;
        }
    }
}