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
            SeedContentList();
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
                Console.WriteLine("Please press any key to continue..."); //just to pause and let user know he is in control of proceeding
                Console.ReadKey(); 

                
                Console.Clear(); // clears the console window to remove all the previous menues etc..

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
            newContent.StarRating = double.Parse(starsAsString); //converts string to double

            //double starAsDouble = Console.Read();
            //newContent.StarRating = starAsDouble; // trying out another way but doesn't work right

            //newContent.StarRating = Console.Read(); //tried this way but return was 56 or 57 for star rating even though input was 8


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
                "7.  Action\n" +
                "8.  Comedy");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString); //converts string to int
            newContent.TypeOfGenre = (GenreType)genreAsInt; //WHY DO I HAVE TO USE (GenreType) instead of just = genreAsInt???

            _contentRepo.AddContentToList(newContent);  // this line adds new created object to list
        }
        //View current streaming content
        private void DisplayAllContent() {
            Console.Clear();
            List<StreamingContent> listOfContent = _contentRepo.GetContentList();
            foreach (StreamingContent content in listOfContent ) {
                Console.WriteLine($"Title:  {content.Title}\n " +
                    $"Description: {content.Description}\n");
            }
        }


        //View existing content by title
        private void DisplayContentByTitle() {
            Console.Clear();
            //Promt user to give title
            Console.WriteLine("Enter the title of the content you would like to see: ");
            //Get input
            string title = Console.ReadLine();

            //Find the content by that title
            StreamingContent content = _contentRepo.GetContentByTitle(title);

            //Display content if it is not null
            if (content != null) {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Maturity Rating: {content.MaturityRating}\n" +
                    $"Stars:  {content.StarRating}\n" +
                    $"Is Family Friendly:  {content.IsFamilyFriendly}\n" +
                    $"Genre:  {content.TypeOfGenre}");

            }
            else {
                Console.WriteLine("No content found for that title");
            }


        }
        //update existing content
        private void UpdateEsistingContent() {
            // Display all content
            DisplayAllContent();

            // Ask for the title of the conent to update
            Console.WriteLine("Enter the title you wish to update: ");

            //Get that title
            string oldTitle = Console.ReadLine();

            //We will build a new object

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
            Console.WriteLine("Is this content family-friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y") {
                newContent.IsFamilyFriendly = true;
            } else {
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
                "7.  Action\n" +
                "8.  Comedy");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;
            
            //Verify 

            bool wasUpdated = _contentRepo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated) {
                Console.WriteLine("Content successfully updated");
            }
            else {
                Console.WriteLine("Not upated");
            }


        }
        //Delete Existing Content
        private void DeleteExistingContent() {

            DisplayAllContent();

            // Get the title they want to remove
            Console.WriteLine("\nEnter the title you would like to remove: ");
            string input = Console.ReadLine();

            // Call he delete method
            bool wasDeleted = _contentRepo.RemoveContentFromList(input);

            // Confirm delete worked
            if (wasDeleted) {
                Console.WriteLine("The content was deleted. ");
            } else {
                Console.WriteLine("The content could not be deleted."); 
            }



        }
        private void SeedContentList() {
            StreamingContent happyGilmore = new StreamingContent("Happy Gilmore", "Funny Golf Movie", "PG-13", 10, true, GenreType.Comedy);
            StreamingContent tombstone = new StreamingContent("Tombstone", "Epic Wester Wyatt Earp", "R", 10, false, GenreType.Action);
            StreamingContent interstellar = new StreamingContent("Interstellar", "Future space travel", "PG-13", 10, true, GenreType.Drama);
            StreamingContent blazing = new StreamingContent("Blazing Saddles", "Satire");
            _contentRepo.AddContentToList(happyGilmore);
            _contentRepo.AddContentToList(tombstone);
            _contentRepo.AddContentToList(interstellar);
            _contentRepo.AddContentToList(blazing);
        }
    }
}
