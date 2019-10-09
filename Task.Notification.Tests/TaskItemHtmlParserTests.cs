using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Task.Notification.Tests
{
    [TestClass]
    public class TaskItemHtmlParserTests
    {
        [TestMethod]
        public void TaskItemsHtmlParser_GivenListOfTasks_ReturnsHtmlOrderedList()
        {
            var expectedResult = "<ol><li>Cuidar dos doguinhos</li><ol><li>Colocar �gua pro Geraldo</li><li>Ra��o especial pra Shirley</li><ol><li>Apenas de manh� e � noite em pouca quantidade</li></ol></ol><li>Abastecer dispensa</li><ol><li>Comprar ovos</li><li>Fazer varej�o</li><ol><li>Beterraba</li><li>Melancia</li><li>Pepino</li></ol></ol><li>Estudar SOLID</li></ol>";

            var tasks = new List<TaskItem>();

            using (var tasksFile = File.OpenText("..\\..\\..\\Tasks.json"))
            {
                var tasksJson = tasksFile.ReadToEnd(); ;
                tasks = JsonConvert.DeserializeObject<List<TaskItem>>(tasksJson);
            }            

            var formatter = new TaskItemHtmlParser();
            var result = formatter.ParseToOrderedList(tasks);

            Assert.AreEqual(expectedResult, result, "Unfortunately you didn't survive the night.");
        }
    }
}