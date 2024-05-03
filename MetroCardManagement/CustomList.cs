using System;

namespace MetroCardManagement
{
    public partial class CustomList<Type>
    {
        //Field
        
        private int _count;
        private int _capacity;

        public int Count { get{return _count;} }
        public int capacity { get{return _capacity;}}

        private Type [] _array;

        
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
            //
            _capacity=_capacity*2;
            Type [] temp =new Type[_capacity];
            
            for(int i =0; i<_count;i++)
            {
                temp[i]=_array[i];
            }
            
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

           
        
         }


}
