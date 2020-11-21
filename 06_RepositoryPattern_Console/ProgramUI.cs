using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console {
    //This method is what runs/starts the application
    class ProgramUI {

        private StreamingContentRepository _contentRepo = new StreamingContentRepository();
        public void Run() {

            Menu();
        }

        // Menu
        private void Menu() {  //private so user cannot pull up this menu
                               //  directly without runnin program through run method
            bool keepRunning = true;
            while (keepRunning) {


                //Display options to user
                Console.WriteLine("Select a menu option: \n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                // Get user input
                string input = Console.ReadLine();

                //Evaluate user input and respond 
                switch (input) {
                    case "1":
                        //Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        //View all content
                        DisplayAllContent();
                        break;
                    case "3":
                        //View by title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        // Update Existing content
                        UpdateEsistingContent();
                        break;
                    case "5":
                        // Delete Existing Content
                        DeleteExistingContent();
                        break;
                    case "6":
                        //Exit
                        Console.WriteLine("Adios");
                    keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;


                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                
                Console.Clear();

            }


        }
        //Create new streaming content
        private void CreateNewContent() {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("Enter the title of the content: ");
            newContent.Title = Console.ReadLine();

            //description
            Console.WriteLine("Enter the description for the new content: ");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, etc.): ");
            newContent.MaturityRating = Console.ReadLine();


            //Star rating
            Console.WriteLine("Enter the star count for the content(5, 6.9, 10, etc.): ");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);


            //IsfamilyFriendly
            Console.WriteLine("Is this content family-friendly? (y/n)" );
            string familyFriendlyString = Console.ReadLine().ToLower();
            
            if (familyFriendlyString == "y") {
                newContent.IsFamilyFriendly = true;
            }
            else {
                newContent.IsFamilyFriendly = false;
            }

            //Genre Type

            Console.WriteLine("Enter the genre number: \n" +
                "1.  Horror\n" +
                "2.  RomCom\n" +
                "3.  SciFi\n" +
                "4.  Documentary\n" +
                "5.  Bromance\n" +
                "6.  Drame\n" +
                "7.  Action");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            _contentRepo.AddContentToList(newContent);
        }
        //View current streaming content
        private void DisplayAllContent() { 
        }


        //View existing content by title
        private void DisplayContentByTitle() {

        }
        //update existing content
        private void UpdateEsistingContent() {

        }
        //Delete Existing Content
        private void DeleteExistingContent() {

        }
    }
}
