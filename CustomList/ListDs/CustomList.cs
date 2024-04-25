using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListDs
{
    //create list class
    public partial class CustomList<Type>
    {
        private int _count;
        private int _capacity;

        public int Count { get{return _count;} }
        public int capacity { get{return _capacity;}}

        private Type [] _array;

        // indexer used to consider the object as array -add the element get the elements
        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value;}
        }
        
        public CustomList(){
            _count=0;
            _capacity=4;
            _array= new Type[_capacity];
        }

        public CustomList(int size){
            _count=0;
            _capacity=size;
            _array =  new Type[_capacity];
        }

        //Create the Add method to add date into List
        public void Add(Type element){
            if(_count==_capacity)
            {
                 GrowSize();
            }
            _array[_count]=element;
            _count++;
        }

        void GrowSize()
        {
            //double the capacity of the array
            _capacity=_capacity*2;
            Type [] temp =new Type[_capacity];
            //storing the previous array element into the new array
            for(int i =0; i<_count;i++)
            {
                temp[i]=_array[i];
            }
            //assigning the new array memaory  to old array
            _array=temp;
        }

        //Creating Add range method - it is used to add the list into another list

            public void AddRange(CustomList<Type> elements)
            {
                _capacity=_count+elements.Count+4;
                Type [] temp =new Type[_capacity];
                //storing the  first list element into the new list
                for(int i =0; i<_count;i++)
                {
                    temp[i]=_array[i];
                }
                //storing the second list element into the new list
                int k =0;
                for(int i =_count;i<_count+elements.Count;i++)
                {
                    temp[i]=elements[k];
                    k++;
                }

                _array = temp;
                _count = _count+elements.Count;
            }

            //creating the contains method
            public bool Contains(Type element){
                bool temp = false;
                foreach(Type data in _array)
                {
                    if(data.Equals(element))
                    {
                        temp=true;
                        break;
                    }
                }
                return temp;
            }
        
        //creating the indexOf Method
        public int IndexOf(Type element){
            int index = -1;
            for(int i =0; i<_count;i++){
                if(element.Equals(_array[i])){
                    index=i;
                    break;
                }
            }
            return index;
        }

        //creating insert method
        public void Insert(int position, Type element){
            //increase the capacity
            _capacity=_capacity+1+4;
            Type [] temp = new Type[_capacity];
            for(int i =0; i<=_count;i++)
            {
                if(i<position)
                {
                    temp[i]=_array[i];
                }
                else if(i==position)
                {
                    temp[i] =element;
                }
                else{
                    temp[i]=_array[i-1];
                }
            }
            _count++;
            _array=temp;
        }
    //creating insertrange method
    public void InsertRange(int position, CustomList<Type> elements)
    {
        _capacity= _count+elements.Count+4;
        Type [] temp = new Type[_capacity];
        for(int i =0; i<position;i++){
            temp[i]=_array[i];

        }
        int j=0;
        for(int i =position;i<position+elements.Count;i++){
            temp[i]=elements[j];
            j++;
        }
        int k =position;
        for(int i =position+elements.Count;i<_count+elements.Count;i++){
            temp[i]=_array[k];
            k++;
        }
        _array=temp;
        _count=_count+elements.Count;
    }
        //creating the RemoveAt method
        //this method is used to remove the element in the particular position
        public void RemoveAt(int position)
        {
            for(int i =0; i<_count-1;i++)
            {
                if(i>=position)
                {
                    _array[i]=_array[i+1];
                }
            }
            _count--;
        }

        //creating the remove method to remove the specified element in the list
        
            public bool Remove(Type element){
                int position = IndexOf(element);
                if(position>=0)
                {
                    RemoveAt(position);
                    return true;

                }
                return false;
            }
   //Reverse Method for reverse the list
        public void Reverse()
        {
            Type [] temp = new Type[_capacity];
            int j =0;
            for(int i = _count-1; i<=0;i++){
                temp[i]=_array[j];
                j++;
            }
            _array=temp;
        }

  //Creating sort method
  public void Sort(){
    for(int i =0; i<_count-1;i++){
        for(int j=0; j<_count-1;j++){
            if(IsGreater(_array[j],_array[j+1])){
            //swap
            Type temp=_array[j+1];
            _array[j+1]=_array[j];
            _array[j]=temp;
        }
        }
    }
  }   
  public bool IsGreater(Type value1, Type value2) {
    int result = Comparer<Type>.Default.Compare(value1,value2);
    if(result>0){
        return true;
    }
    else{
        return false;
    }
  }  
   
    }
}
