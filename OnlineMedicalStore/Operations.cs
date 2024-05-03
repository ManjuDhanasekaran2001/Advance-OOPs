using System;

namespace OnlineMedicalStore
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Security.Cryptography.X509Certificates;

    namespace OnlineGroceryShopApplication
    {
        public static class Operations
        {
            static UserDetails currentUser;
            static CustomList<UserDetails> userList = new CustomList<UserDetails>();
            static CustomList<MedicineDetails> medicineList = new CustomList<MedicineDetails>();
            static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();

            public static void ManiMenu()
            {
                Console.WriteLine("WelCome To Online Shopping App");
                string temp = "yes";
                do
                {

                    Console.WriteLine($"1. user Registration \n2. user Login\n3. Exit");
                    Console.Write("Selct The Option");
                    int MainChoice = int.Parse(Console.ReadLine());
                    switch (MainChoice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Welcome to user Registration");
                                UserDetails();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Welcome to user Login");
                                userLogin();
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

            public static void UserDetails()
            {
                Console.Write("Enter your name : ");
                string name = Console.ReadLine();
                Console.Write("Enter your Age : ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Enter your City : ");
                string city = Console.ReadLine();
                Console.Write("Enter the Phone Number : ");
                string moblie = Console.ReadLine();
                Console.Write("Enter the balance : ");
                double balance = double.Parse(Console.ReadLine());
                UserDetails user = new UserDetails(name,age,city,moblie,balance);
                userList.Add(user);
                Console.WriteLine("Your registrartion was Successfull : Your user ID is : " + user.UserID);

            }
            public static void userLogin()
            {
                Console.Write("Entre the User ID : ");
                string userPickedUserID = Console.ReadLine().ToUpper();
                bool flag = true;
                foreach (UserDetails user in userList)
                {
                    if (userPickedUserID.Equals(user.UserID))
                    {
                        currentUser = user;
                        flag = false;
                        SubMenu();
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Invalid user ID");
                }
            }

            public static void SubMenu()
            {
                string temp = "yes";
                do
                {
                    Console.WriteLine("********SubMenu**********");
                    Console.WriteLine("1. Show MedicineList\n2. PurChase Medicine\n3. Modify Medicine\n4. Cancel Purchase\n5. Show Purchase History\n6. Recharge Wallet\n7. Show balance\n8. Exit");
                    Console.Write("Select The Option : ");
                    int mainChoice = int.Parse(Console.ReadLine());
                    switch (mainChoice)
                    {
                        case 1:
                            {
                                Console.WriteLine("***********ShowMedicineDetail*************");
                                ShowMedicineDetails();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("************PurchaseMedicine************");
                                PurchaseMedicine();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("********ModifyMedicine***********");
                                ModifyMedicine();
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("*************CancelPurchase*************");
                                CancelPurchase();
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("********ShowProductHistory*********");
                                ShowProductHistory();
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("**********WalletRechargeer************");
                                WalletRecharge();
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

            public static void ShowMedicineDetails()
            {
                foreach (MedicineDetails medicine in medicineList)
                {

                    Console.WriteLine($"{medicine.MedicineID}|{medicine.MedicineName}|{medicine.AvailableCount}|{medicine.Price}|{medicine.DateOFExpiry.ToString("dd/MM/yyyy")}|");

                }
            }
            public static void ShowProductHistory()
            {
                foreach (OrderDetails order in orderList)
                {
                    if(currentUser.UserID.Equals(order.UserID)){
                    Console.WriteLine($"{order.OrderID}|{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.TotalPrice}|{order.OrderStatus}|");
                    }
                }
            }
            public static void WalletRecharge()
            {
                Console.Write("Enter The amount : ");
                double balance = double.Parse(Console.ReadLine());
                currentUser.WalletRecharge(balance);
                Console.WriteLine("Your Balance is : " + currentUser.WalletBalance);
            }
            public static void PurchaseMedicine()
            {

                bool flag = true;
                double TotalBalance = 0;


                ShowMedicineDetails();
                Console.Write("Select the Medicine ID : ");
                string userOrderID = Console.ReadLine().ToUpper();

                foreach (MedicineDetails medicine in medicineList)
                {
                    if (userOrderID.Equals(medicine.MedicineID))
                    {
                        flag = false;
                        Console.Write("Enter Quantity you want :");
                        int userquantity = int.Parse(Console.ReadLine());
                        if (userquantity <= medicine.AvailableCount)
                        {

                            if (medicine.DateOFExpiry > DateTime.Now)
                            {
                                TotalBalance = medicine.Price * userquantity;
                                OrderDetails order = new OrderDetails(currentUser.UserID, medicine.MedicineID, userquantity, TotalBalance, DateTime.Now, OrderStatus.Purchased);
                                orderList.Add(order);
                                medicine.AvailableCount -= userquantity;
                                Console.WriteLine("Product successfully added to cart");
                            }
                            else
                            {
                                Console.Write("Medicine is not availabe");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Medicine Quantity is not availabe.");
                        }
                    }
                }


                if (flag)
                {
                    Console.WriteLine("Invalid Medince ID.");
                    return;
                }
                Console.Write("Do you want to confirm the order");
                string userWish = Console.ReadLine();
                if (userWish == "yes")
                {


                    if (currentUser.WalletBalance >= TotalBalance)
                    {

                        currentUser.DeductBalance(TotalBalance);
                        ShowBalance();



                        Console.WriteLine("medicine  Purchaed successful");

                    }
                    else
                    {

                        Console.WriteLine("Insufficient account balance recharge . ");

                    }

                }
                else
                {
                    ReturningProduct(orderList, userOrderID);

                }




            }

            public static void ReturningProduct(CustomList<OrderDetails> tempList, string medicineID)
            {

                foreach (MedicineDetails medicine in medicineList)
                {
                    foreach (OrderDetails order in tempList)
                    {
                        if(medicineID.Equals(order.OrderID)){
                        if (medicine.MedicineID.Equals(order.MedicineID))
                        {
                            medicine.AvailableCount += order.MedicineCount;
                        }
                        }
                    }
                }

            }
            public static void ModifyMedicine()
            {

                bool flag1 = true;
                foreach (OrderDetails order in orderList)

                {
                    if (currentUser.UserID.Equals(order.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                    {
                        flag1 = false;
                        Console.WriteLine($"{order.OrderID}|{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.TotalPrice}|{order.OrderStatus}");

                    }
                }
                if (flag1)
                {
                    Console.WriteLine("There is No order to Modify");
                    return;
                }
                Console.Write("Pick your orderr ID from The above List");
                string userOrderID = Console.ReadLine();

                Console.WriteLine("1.Add Item\n2. Remove Item");
                Console.Write("Select the Option");
                int userChoic = int.Parse(Console.ReadLine());




                

                switch (userChoic)
                {
                    case 1:
                        {



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
                                if (userOrderID.Equals(order.OrderID))
                                {
                                    foreach (MedicineDetails medicine in medicineList)
                                    {
                                        if (order.MedicineID.Equals(medicine.MedicineID) && userQuantity <= (medicine.AvailableCount))
                                        {
                                            double totalPrice = userQuantity * medicine.Price;
                                            currentUser.DeductBalance(totalPrice);
                                            medicine.AvailableCount -= userQuantity;
                                            order.TotalPrice += totalPrice;
                                            order.MedicineCount += userQuantity;

                                            Console.WriteLine("Order modified successfully.");
                                        }
                                    }
                                }
                            }


                            break;
                        }
                    case 2:
                        {
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
                                if (userOrderID.Equals(order.OrderID))
                                {
                                    foreach (MedicineDetails medicine in medicineList)
                                    {
                                        if (order.MedicineID.Equals(medicine.MedicineID) && userQuantity <= (order.MedicineCount))
                                        {
                                            double totalPrice = userQuantity * medicine.Price;
                                            currentUser.WalletRecharge(totalPrice);
                                            medicine.AvailableCount -= userQuantity;
                                            order.TotalPrice -= totalPrice;
                                            order.MedicineCount -= userQuantity;

                                            Console.WriteLine("Order modified successfully.");
                                        }
                                    }
                                }
                            }




                            break;
                        }
                }


                
            }
            public static void CancelPurchase()
            {
                bool flag = true;
                foreach (OrderDetails order in orderList)
                {
                    if (currentUser.UserID.Equals(order.UserID) && (order.OrderStatus.Equals(OrderStatus.Purchased)))
                {
                        flag = false;
                         Console.WriteLine($"{order.OrderID}|{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.TotalPrice}|{order.OrderStatus}");

                }
                        
                if (flag)
                {
                    Console.WriteLine("Ther is no Order to Cancel.");
                    return;
                }

               


            }
             Console.WriteLine("Pick The Order ID : ");
                String userPickedID = Console.ReadLine();
                foreach(OrderDetails order in orderList){
                    
                    ReturningProduct(orderList,userPickedID);
                    currentUser.WalletRecharge(order.TotalPrice);
                }
            }
            public static void ShowBalance()
            {
                Console.WriteLine("Your Balance is : " + currentUser.WalletBalance);
            }


            public static void AddDefaultData()
            {
                UserDetails user1 = new UserDetails("Ravi", 33, "Theni", "9877774440", 400);
                UserDetails user2 = new UserDetails("Baskaran", 33, "Chennai", "8847757470", 500);
                userList.Add(user1);
                userList.Add(user2);



                MedicineDetails medicine1 = new MedicineDetails("Paracitamol", 40, 5, new DateTime(2024, 06, 30));
                MedicineDetails medicine2 = new MedicineDetails("Calpol", 10, 5, new DateTime(2024, 05, 30));
                MedicineDetails medicine3 = new MedicineDetails("Gelucil", 3, 40, new DateTime(2024, 04, 30));
                MedicineDetails medicine4 = new MedicineDetails("Metrogel", 5, 50, new DateTime(2024, 12, 30));
                MedicineDetails medicine5 = new MedicineDetails("Povidin Iodin", 10, 50, new DateTime(2024, 10, 30));

                medicineList.AddRange(new CustomList<MedicineDetails>() { medicine1, medicine2, medicine3, medicine4, medicine5 });

                OrderDetails order1 = new OrderDetails("UID1001", "MD101", 3, 15, new DateTime(2022, 11, 13), OrderStatus.Purchased);
                OrderDetails order2 = new OrderDetails("UID1001", "MD102", 2, 10, new DateTime(2022, 11, 13), OrderStatus.Cancelled);
                OrderDetails order3 = new OrderDetails("UID1001", "MD104", 2, 100, new DateTime(2022, 11, 13), OrderStatus.Purchased);
                OrderDetails order4 = new OrderDetails("UID1002", "MD103", 3, 120, new DateTime(2022, 11, 15), OrderStatus.Cancelled);
                OrderDetails order5 = new OrderDetails("UID1002", "MD105", 5, 250, new DateTime(2022, 11, 15), OrderStatus.Purchased);
                OrderDetails order6 = new OrderDetails("UID1002", "MD102", 3, 15, new DateTime(2022, 11, 15), OrderStatus.Purchased);




                orderList.AddRange(new CustomList<OrderDetails>() { order1, order2, order3, order4, order5, order6 });
            }
        }
    }

}
