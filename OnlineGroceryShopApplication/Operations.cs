using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace OnlineGroceryShopApplication
{
    public static class Operations
    {
        static CustomerRegistration currentUser;
        static CustomList<CustomerRegistration> customerList = new CustomList<CustomerRegistration>();
        static CustomList<BookingDetails> bookingList = new CustomList<BookingDetails>();
        static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        static CustomList<ProductDetails> ProductList = new CustomList<ProductDetails>();
        public static void ManiMenu()
        {
            Console.WriteLine("WelCome To Online Shopping App");
            string temp = "yes";
            do
            {

                Console.WriteLine($"1. Customer Registration \n2. Customer Login\n3. Exit");
                Console.Write("Selct The Option");
                int MainChoice = int.Parse(Console.ReadLine());
                switch (MainChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("Welcome to Customer Registration");
                            CustomerRegistration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Welcome to Customer Login");
                            CustomerLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Application Exited Successfullu");
                            temp = "no";
                            break;
                        }
                }
            } while (temp == "yes");
        }

        public static void CustomerRegistration()
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Father Name : ");
            string fathername = Console.ReadLine();
            Console.Write("Enter yor Gender : ");
            Gender gender =Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("Enter your Mobile Number : ");
            long mobile = long.Parse(Console.ReadLine());
            Console.Write("Enter your Date of Birth (dd/MM/yyyy): ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Enter your Mail ID :");
            string mail = Console.ReadLine();
            Console.Write("Enter your Balance : ");
            double balance = double.Parse(Console.ReadLine());

            CustomerRegistration customer = new CustomerRegistration(balance,name,fathername,gender,mobile,dob,mail);
            customerList.Add(customer);
            Console.WriteLine("Your registrartion was Successfull : Your Customer ID is : "+customer.CustomeID);

                    }
        public static void CustomerLogin()
        {
            Console.Write("Entre the Customer ID : ");
            string userCustomerID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (CustomerRegistration customer in customerList)
            {
                if (userCustomerID.Equals(customer.CustomeID))
                {
                    currentUser = customer;
                    flag = false;
                    SubMenu();
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid Customer ID");
            }
        }

        public static void SubMenu()
        {
            string temp = "yes";
            do
            {
                Console.WriteLine("********SubMenu**********");
                Console.WriteLine("1. Show Customer details\n2. Show Product Details\n3. Wallet Recharge\n4. Take Order\n5. Modify Order Quantity\n6. cancel Order\n7. Show balance\n8. Exit");
                Console.Write("Select The Option : ");
                int mainChoice = int.Parse(Console.ReadLine());
                switch (mainChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("***********CustomerDetails*************");
                            ShowCustomerDetails();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("************Product ddetails************");
                            ShowproductDeatails();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("********Wallet Recharge***********");
                            WalletRecharge();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("*************Take Order*************");
                            TakeOrder();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("********Modify Order Quantity*********");
                            ModifyOrderQuantity();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("**********cancel Order************");
                            CancelOrder();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("********Show balance********");
                            ShowBalance();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("return to the Main Menu");
                            temp = "no";
                            break;
                        }

                }
            } while (temp == "yes");
        }

        public static void ShowCustomerDetails()
        {
            foreach (CustomerRegistration customer in customerList)
            {
                if (currentUser.CustomeID.Equals(customer.CustomeID))
                {
                    Console.WriteLine($"{customer.CustomeID}|{customer.Name}|{customer.FatherName}|{customer.Gender}|{customer.Mobile}|{customer.DOB.ToString("dd/MM/yyyy")}|{customer.MailID}|{customer.WalletBalance}|");
                }
            }
        }
        public static void ShowproductDeatails()
        {
            foreach (ProductDetails product in ProductList)
            {
                Console.WriteLine($"{product.ProductID}|{product.ProductName}|{product.QuantityAvailable}|{product.PricePerQuantity}|");
            }
        }
        public static void WalletRecharge()
        {
            Console.Write("Enter The amount : ");
            double balance = double.Parse(Console.ReadLine());
            currentUser.WalletRecharge(balance);
            Console.WriteLine("Your Balance is : " + currentUser.WalletBalance);
        }
        public static void TakeOrder()
        {
            Console.Write("You want to Purchse :");
            string userChoice = Console.ReadLine();
            if (userChoice == "yes")
            {
                bool flag = true;
                double totalBalance = 0;
                BookingDetails Booking1 = new BookingDetails(currentUser.CustomeID, 0, DateTime.Now, BookingStatus.Initiated);
                CustomList<OrderDetails> tempOrderList = new CustomList<OrderDetails>();
                string temp = "yes";
                do
                {
                    ShowproductDeatails();
                    Console.Write("Select the Product ID : ");
                    string userProductID = Console.ReadLine().ToUpper();

                    foreach (ProductDetails product in ProductList)
                    {
                        if (userProductID.Equals(product.ProductID))
                        {
                            flag = false;
                            Console.Write("Enter Quantity you want :");
                            int userQuantity = int.Parse(Console.ReadLine());
                            if (userQuantity <= product.QuantityAvailable)
                            {
                                totalBalance = product.PricePerQuantity * userQuantity;
                                OrderDetails order = new OrderDetails(Booking1.BookingID, userProductID, userQuantity, totalBalance);
                                tempOrderList.Add(order);
                                product.QuantityAvailable -= userQuantity;
                                Console.WriteLine("Product successfully added to cart");
                            }
                            else
                            {
                                Console.WriteLine("Quantity is not availabe.");
                            }
                        }
                    }
                    Console.Write("You want tobook another Product (yes/no) : ");
                    temp = Console.ReadLine();

                } while (temp == "yes");
                if (flag)
                {
                    Console.WriteLine("Invalid ProductID.");
                    return;
                }
                Console.Write("Do you want to confirm the order");
                string userWish = Console.ReadLine();
                if (userWish == "yes")
                {
                    bool temp1 = true;
                    do
                    {
                        if (currentUser.WalletBalance >= totalBalance)
                        {
                            temp1 = false;
                            currentUser.WalletBalance -= totalBalance;
                            ShowBalance();
                            Booking1.BookingStatus = BookingStatus.Booked;
                            Booking1.TotalPrice = totalBalance;
                            orderList.AddRange(tempOrderList);
                            bookingList.Add(Booking1);
                            Console.WriteLine("Booking successful");

                        }
                        else
                        {

                            Console.WriteLine("Insufficient account balance recharge with " + totalBalance);
                            WalletRecharge();
                        }
                    } while (temp1);
                }
                else
                {
                    ReturningProduct(tempOrderList, Booking1.BookingID);

                }


            }
            else
            {
                return;
            }
        }

        public static void ReturningProduct(CustomList<OrderDetails> tempList, string bookingID)
        {

            foreach (ProductDetails product in ProductList)
            {
                foreach (OrderDetails order in tempList)
                {
                    if (product.ProductID.Equals(order.ProductID) && order.BookingID.Equals(bookingID))
                    {
                        product.QuantityAvailable += order.PurchaseCount;
                    }
                }
            }

        }
        public static void ModifyOrderQuantity()
        {

            bool flag1 = true;
            foreach (BookingDetails booking in bookingList)

            {
                if (currentUser.CustomeID.Equals(booking.CustomerID) && booking.BookingStatus.Equals(BookingStatus.Booked))
                {
                    flag1 = false;
                    Console.WriteLine($"{booking.BookingID}|{booking.CustomerID}|{booking.TotalPrice}|{booking.DateOfBooking.ToString("dd/MM/yyyy")}|{booking.BookingStatus}");

                }
            }
            if (flag1)
            {
                Console.WriteLine("There is No order to Modify");
                return;
            }
            Console.Write("Pick your Booking ID from The above List");
            string userBookingID = Console.ReadLine();

            Console.WriteLine("1.Add Item\n2. Remove Item");
            Console.Write("Select the Option");
            int userChoic = int.Parse(Console.ReadLine());




            bool flag = true;
            foreach (BookingDetails booking in bookingList)
            {
                switch (userChoic)
                {
                    case 1:
                        {
                            if (userBookingID.Equals(booking.BookingID))
                            {
                                flag = false;
                                foreach (OrderDetails order in orderList)
                                {
                                    if (userBookingID.Equals(order.BookingID))
                                    {
                                        Console.WriteLine($"{order.OrderID}|{order.BookingID}|{order.ProductID}|{order.PurchaseCount}|{order.PriceOfOrder}|");
                                    }
                                }

                                Console.Write("Pick The order Id from The OrderList : ");
                                string userItemID = Console.ReadLine();
                                Console.Write("Enter the product quantity: ");
                                int userQuantity;
                                bool temp = int.TryParse(Console.ReadLine(), out userQuantity);
                                while (!temp)
                                {
                                    System.Console.Write("Invalid Input. Enter a Valid Input : ");
                                    temp = int.TryParse(Console.ReadLine(), out userQuantity);
                                }
                                foreach (OrderDetails order in orderList)
                                {
                                    if (userItemID.Equals(order.OrderID))
                                    {
                                        foreach (ProductDetails product in ProductList)
                                        {
                                            if (order.ProductID.Equals(product.ProductID) && userQuantity <= (product.QuantityAvailable))
                                            {
                                                double totalPrice = userQuantity * product.PricePerQuantity;
                                                currentUser.WalletBalance -= (totalPrice);
                                                product.QuantityAvailable -= userQuantity;
                                                order.PriceOfOrder += totalPrice;
                                                order.PurchaseCount += userQuantity;
                                                booking.TotalPrice += totalPrice;
                                                Console.WriteLine("Order modified successfully.");
                                            }
                                        }
                                    }
                                }

                            }
                            break;
                        }
                    case 2 : {
                        
                         if (userBookingID.Equals(booking.BookingID))
                            {
                                OrderDetails order1;
                                flag = false;
                                foreach (OrderDetails order in orderList)
                                {
                                    if (userBookingID.Equals(order.BookingID))
                                    {
                                        Console.WriteLine($"{order.OrderID}|{order.BookingID}|{order.ProductID}|{order.PurchaseCount}|{order.PriceOfOrder}|");
                                    }
                                }

                                Console.Write("Pick The order Id from The OrderList : ");
                                string userItemID = Console.ReadLine();
                                Console.Write("Enter the product quantity: ");
                                int userQuantity;
                                bool temp = int.TryParse(Console.ReadLine(), out userQuantity);
                                while (!temp)
                                {
                                    System.Console.Write("Invalid Input. Enter a Valid Input : ");
                                    temp = int.TryParse(Console.ReadLine(), out userQuantity);
                                }
                                foreach (OrderDetails order in orderList)
                                {
                                    order1 = order;

                                    if (userItemID.Equals(order.OrderID))
                                    {
                                        foreach (ProductDetails product in ProductList)
                                        {
                                            
                                            if (order.ProductID.Equals(product.ProductID) && userQuantity <= (order.PurchaseCount))
                                            {
                                                //double totalPrice = userQuantity * product.PricePerQuantity;
                                                currentUser.WalletBalance += userQuantity*product.PricePerQuantity;
                                                product.QuantityAvailable += userQuantity;
                                                order.PurchaseCount-=userQuantity;
                                                order.PriceOfOrder-=userQuantity*product.PricePerQuantity;
                                                booking.TotalPrice -= userQuantity*product.PricePerQuantity;
                                                Console.WriteLine("Order modified successfully.");
                                            }
                                        }
                                    }
                                }
                               

                            }

                        break;
                    }    
                }
            }

            if (flag)
            {
                Console.WriteLine("Invalid Oreder Id");
            }
        }
        public static void CancelOrder()
        {
            bool flag = true;
            foreach (BookingDetails booking in bookingList)
            {
                if (currentUser.CustomeID.Equals(booking.CustomerID) && booking.BookingStatus.Equals(BookingStatus.Booked))
                {
                    flag = false;
                    Console.WriteLine($"{booking.BookingID}|{booking.CustomerID}|{booking.TotalPrice}|{booking.DateOfBooking.ToString("dd/MM/yyyy")}|{booking.BookingStatus}");
                    Console.Write("Pick the Booking ID : ");
                    string userBookigID = Console.ReadLine();
                    if (userBookigID.Equals(booking.BookingID))
                    {
                        booking.BookingStatus = BookingStatus.Cancelled;
                        currentUser.WalletBalance += booking.TotalPrice;
                        Console.WriteLine("Order cancelled succesfully");
                        ReturningProduct(orderList, booking.BookingID);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Bookiing Id.");
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Ther is no Order to Cancel.");
            }
        }
        public static void ShowBalance()
        {
            Console.WriteLine("Your Balance is : " + currentUser.WalletBalance);
        }


        public static void AddDefaultData()
        {
            CustomerRegistration customer1 = new CustomerRegistration(10000, "Ravi", "Ettapparajan", Gender.Male, 974774646, new DateTime(1999, 11, 11), "ravi@gmail.com");
            CustomerRegistration customer2 = new CustomerRegistration(15000, "Baskaran", "Sethurajan", Gender.Male, 847575775, new DateTime(1999, 11, 11), "baskaran@gmail.com");
            customerList.Add(customer1);
            customerList.Add(customer2);

            ProductDetails product1 = new ProductDetails("Sugar", 20, 40);
            ProductDetails product2 = new ProductDetails("Rice", 100, 50);
            ProductDetails product3 = new ProductDetails("Milk", 10, 40);
            ProductDetails product4 = new ProductDetails("Coffee", 10, 10);
            ProductDetails product5 = new ProductDetails("Tea", 10, 10);
            ProductDetails product6 = new ProductDetails("Masala Powder", 10, 20);
            ProductDetails product7 = new ProductDetails("Salt", 10, 10);
            ProductDetails product8 = new ProductDetails("Turmeric Powder", 10, 25);
            ProductDetails product9 = new ProductDetails("Chilli Powder", 10, 20);
            ProductDetails product10 = new ProductDetails("Groundnut Oil", 10, 140);

            ProductList.AddRange(new CustomList<ProductDetails>() { product1, product2, product3, product3, product4, product5, product6, product7, product8, product9, product10 });

            BookingDetails booking1 = new BookingDetails("CID1001", 220, new DateTime(2022, 07, 26), BookingStatus.Booked);
            BookingDetails booking2 = new BookingDetails("CID1002", 400, new DateTime(2022, 07, 26), BookingStatus.Booked);
            BookingDetails booking3 = new BookingDetails("CID1001", 280, new DateTime(2022, 07, 26), BookingStatus.Cancelled);
            BookingDetails booking4 = new BookingDetails("CID1002", 0, new DateTime(2022, 07, 26), BookingStatus.Initiated);

            bookingList.AddRange(new CustomList<BookingDetails>() { booking1, booking2, booking3, booking4 });

            OrderDetails order1 = new OrderDetails("BID3001", "PID2001", 2, 80);
            OrderDetails order4 = new OrderDetails("BID3001", "PID2002", 2, 100);
            OrderDetails order5 = new OrderDetails("BID3001", "PID2003", 1, 40);
            OrderDetails order2 = new OrderDetails("BID3002", "PID2001", 1, 40);
            OrderDetails order6 = new OrderDetails("BID3002", "PID2002", 4, 200);
            OrderDetails order7 = new OrderDetails("BID3002", "PID20010", 1, 140);
            OrderDetails order8 = new OrderDetails("BID3002", "PID2009", 1, 20);
            OrderDetails order3 = new OrderDetails("BID3003", "PID2002", 2, 100);
            OrderDetails order9 = new OrderDetails("BID3003", "PID2008", 4, 100);
            OrderDetails order10 = new OrderDetails("BID3003", "PID2001", 2, 80);




            orderList.AddRange(new CustomList<OrderDetails>() { order1, order4, order5, order2, order6, order7, order8, order3, order9, order10 });
        }
    }
}
