using System;

namespace LibraryManagement
{
    public class BookDetails
    {
        /*
        1.	BookID (Auto Increment - BID1000)
        2.	BookName
        3.	AuthorName
        4.	BookCount

        */

        //Field 
        //static 
        private static int s_bookID = 1000;

        //Property
        public string BookID { get; }//Read only Property
        public string BookName{ get; set; }
        public string AuthorName { get; set; }
        public long BookCount { get; set; }

        //Constructor
        public BookDetails(string bookNmae, string authorname, long bookCount){
            //Auto Incrementation
            s_bookID++;
            BookID="BID"+s_bookID;
            BookName=bookNmae;
            AuthorName=authorname;
            BookCount=bookCount;
        }
    }
}
