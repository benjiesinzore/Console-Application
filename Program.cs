//Nishi Patel
//04-14-2023
using System;

namespace MyApplication
{

    class super_store
    {
        decimal all_cost = 0m;
        string base_machine = "";
        string ss_machine = "";
        Boolean upgrade = false;
        Boolean package_added = false;
        int total_ram = 0;
        string name_to_add = "";
        Boolean have_name = false;
        string u_name = "";


        void write_menu(String menu)
        {

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(menu);
            Console.ForegroundColor = ConsoleColor.White;


        }

        void write_error(String error)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ForegroundColor = ConsoleColor.White;


        }

        void write_totals(string totals)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(totals);
            Console.ForegroundColor = ConsoleColor.White;


        }
        void write_summery(string summery)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(summery);
            Console.ForegroundColor = ConsoleColor.White;


        }


        Boolean checkChoice(string input)
        {

            if (input.Equals("y") || input.Equals("Y") || input.Equals("N") || input.Equals("n"))
            {
                return true;
            }

            return false;


        }


        Boolean checkChoice(int input)
        {

            if (input >= 1 && input <= 4)
            {
                return true;
            }

            return false;


        }


        int stage_1()
        {

            Console.WriteLine("Bleeps and Bloops computing superstore");

            string string_ = "What kind of base machine would you like \n" +
                "1. Gaming Rig Base $2,000 \n" +
                "2. Workstation $1,500 \n" +
                "3. Desktop $1,000 \n" +
                "4. Small Form Factor $800 \n";

            write_menu(string_);
            Console.Write("1,2,3 or 4:");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (checkChoice(choice))
            {

                if (choice == 1)
                {
                    all_cost += 2000;
                    base_machine = "Gaming Rig Base";
                }

                else if (choice == 2)
                {
                    all_cost += 1500;
                    base_machine = "Workstation";
                }

                else if (choice == 3)
                {
                    all_cost += 1000;
                    base_machine = "Desktop";
                }

                else if (choice == 4)
                {
                    all_cost += 800;
                    base_machine = "Small Form Factor";
                }

                write_totals("Cost so far is $" + String.Format("{0:F2}", all_cost));

            }
            else
            {


                write_error("Invalid machine selection. Try again");
                stage_1();

            }

            return choice;

        }

        void stage_2()
        {

            string string_ = "What kind of CPU would you like?\n" +
                "1. Intel Core I9-10900X - $0 \n" +
                "2. Intel Core I9-10920X - $250 \n" +
                "3. Intel Core I9-10940X - $400 \n" +
                "4. Intel Core I9-10980XE - $820 \n";

            write_menu(string_);
            Console.WriteLine("1,2,3 or 4:");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (checkChoice(choice))
            {

                if (choice == 1)
                {
                    all_cost += 0;
                    ss_machine = "Intel Core I9-10900X";
                }

                else if (choice == 2)
                {
                    all_cost += 250;
                    ss_machine = "Intel Core I9-10920X";
                }

                else if (choice == 3)
                {
                    all_cost += 400;
                    ss_machine = "Intel Core I9-10940X";
                }

                else if (choice == 4)
                {
                    all_cost += 820;
                    ss_machine = "Intel Core I9-10980XE";
                }



                write_totals("Cost so far is $" + String.Format("{0:F2}", all_cost));

            }
            else
            {

                Console.WriteLine("Invalid base machine selection. Try again");
                stage_2();
            }


        }


        void stage_3(int user_choice)
        {
            string _m = "Would you like upgrade to windows 11 pro $120 (y/n)?";

            write_menu(_m);
            string choice = Console.ReadLine();
            if (checkChoice(choice) == false)
            {

                write_error("Invalid choice. Try again");
                stage_3(user_choice);
            }
            else
            {

                if (choice.Equals("y") || choice.Equals("Y"))
                {
                    all_cost += 120;

                    write_totals("Cost so far is $" + String.Format("{0:F2}", all_cost));
                    upgrade = true;
                }


                if (user_choice != 1)
                {

                    Console.WriteLine("Would you like to add our Sound and Grapgic package for $ 500 (y/n)?");
                    choice = Console.ReadLine();
                    while (checkChoice(choice) == false)
                    {


                        write_error("Invalid choice. Try again");


                        write_menu("Would you like to add our Sound and Grapgic package for $ 500 (y/n)?");
                        choice = Console.ReadLine();

                    }

                    if (choice.Equals("y") || choice.Equals("Y"))
                    {
                        all_cost += 500;

                        write_totals("Cost so far is $" + String.Format("{0:F2}", all_cost));
                        package_added = true;
                    }



                }
            }

        }


        void stage_4()
        {
            string _m = "Please enter how much amount of Ram in multiple of 8GB:";

            Console.Write(_m);
            int choice = Convert.ToInt32(Console.ReadLine());
            if ((choice % 8 == 0))
            {
                if (choice > 8)
                {
                    int rem = ((choice / 8) - 1) * 100;
                    all_cost += rem;

                    write_totals("Cost so far is $" + String.Format("{0:F2}", all_cost));
                }
                else
                {

                    write_totals("Cost so far is $" + String.Format("{0:F2}", all_cost));
                }
                total_ram = choice;
            }
            else
            {
                if (choice < 8)
                {
                    write_error("Memory should be atleast 8 ");
                }
                else
                {
                    write_error("Memory should be a multiple of 8");

                }
                stage_4();
            }

        }


        void stage_5()
        {

            string _m = "Would you like to engrave anything to the system?";

            write_menu(_m);
            name_to_add = Console.ReadLine();

            if (name_to_add != null && name_to_add != "")
            {
                have_name = true;
            }

            _m = "Please Enter email to get updates..";

            write_menu(_m);
            string phone = Console.ReadLine();


        }

        void stage_6()
        {

            string _m = "Please Enter a Name for this order:";

            write_menu(_m);
            u_name = Console.ReadLine();

            while (u_name == null || u_name == "")
            {


                write_error("We do care about you. Please enter your name. Try again");

                write_menu(_m);
                u_name = Console.ReadLine();
            }


        }


        void fstage()
        {


            string summery_details = "Thank you for this order " + u_name + "\n";
            summery_details += "Order summary \n";
            summery_details += "You orderd " + total_ram + "GB " + base_machine + " " + ss_machine + " \n";

            if (have_name)
            {
                summery_details += "with " + name_to_add + " inscribed!! \n";
            }

            if (upgrade)
            {
                summery_details += "We wil add windows 11 pro!! \n";
            }

            if (package_added)
            {
                summery_details += " Our Sound and Graphic package will be installed!! \n";
            }


            summery_details += "All this for only " + all_cost.ToString("0.##") + " Thanks for your Order! " + u_name;

            write_summery(summery_details);
        }


        static void Main(string[] args)
        {
            super_store c = new super_store();
            int uchoice = c.stage_1();
            c.stage_2();
            c.stage_3(uchoice);
            c.stage_4();
            c.stage_5();
            c.stage_6();
            c.fstage();


        }

    }
}







