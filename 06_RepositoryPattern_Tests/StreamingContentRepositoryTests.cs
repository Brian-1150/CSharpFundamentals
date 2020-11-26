using System;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
	[TestClass]
	public class StreamingContentRepositoryTests
	{
		private StreamingContentRepository _repo;
		private StreamingContent _content;

		[TestInitialize]
		public void Arrange() {
			_repo = new StreamingContentRepository();
			_content = new StreamingContent("Happy Gilmore", "Funny Golf Movie", "PG-13", 10, true, GenreType.Comedy);

			_repo.AddContentToList(_content);

        }


		//Add Method
		[TestMethod]
		public void AddToList_ShouldGetNotNull() {
			//Arrange --> Setting up the playing field
			StreamingContent content = new StreamingContent();
			content.Title = "Toy Story";
			StreamingContentRepository repository = new StreamingContentRepository();

			//Act --> Get/run the code we want to test
			repository.AddContentToList(content);
			StreamingContent contentFromDirectory = repository.GetContentByTitle("Toy Story");

			//Assert --> Use the assert class to verify the expected outcomeb
			Assert.IsNotNull(contentFromDirectory);
		
		}
        //Update
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue() {
			//Arrange
			//TestInitialize
			StreamingContent newContent = new StreamingContent("Happy Gilmore", "Funny Adam Sandler Golf Movie", "PG-13", 12, true, GenreType.Comedy);

			//Act 
			bool updateResult = _repo.UpdateExistingContent("Happy Gilmore", newContent);

			//Assert
			Assert.IsTrue(updateResult);
        }
		[DataTestMethod]
		[DataRow("Happy Gilmore", true)]
		[DataRow("Toy Story", false)]
		public void UpdateExistingContent_ShouldMatchGivenBool(string originalTitle, bool shouldUpdate) {
			//Arrange
			//TestInitialize
			StreamingContent newContent = new StreamingContent("Happy Gilmore", "Funny Adam Sandler Golf Movie", "PG-13", 12, true, GenreType.Comedy);

			//Act 
			bool updateResult = _repo.UpdateExistingContent(originalTitle, newContent);

			//Assert
			Assert.AreEqual(shouldUpdate, updateResult);
		}
        [TestMethod]
        public void MyTestMethod() {

        }
		public void DeleteContent_ShouldReturnTrue() {
			//Arragne

			//Act
			bool deleteResult = _repo.RemoveContentFromList(_content.Title);

			//Assert
			Assert.IsTrue(deleteResult);
        }

        }
		
		}
	

