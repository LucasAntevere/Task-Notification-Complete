using System.Collections.Generic;
using System.Linq;

namespace Task.Notification
{
    public class TaskItemHtmlParser
    {
        public string ParseToOrderedList(List<TaskItem> tasks)
        {
            var composite = BuildHtmlTree("ol", 1, tasks);

            return composite.GetHtml();
        }

        private IHtmlComponent BuildHtmlTree(string tag, int level, List<TaskItem> tasks)
        {
            var nodes = new List<IHtmlComponent>();

            var levelTasks = GetTasksByLevel(tasks, level);

            foreach (var levelTask in levelTasks)
            {
                var childrenTasks = GetTasksStartingWith(tasks, levelTask.Priority);

                if (childrenTasks.Any())
                {
                    nodes.Add(new HtmlLeaf("li", levelTask.Description));
                    nodes.Add(BuildHtmlTree("ol", level + 1, childrenTasks));
                }
                else
                    nodes.Add(new HtmlLeaf("li", levelTask.Description));
            }

            return new HtmlComposite(tag, nodes.ToArray());
        }

        private List<TaskItem> GetTasksByLevel(List<TaskItem> tasks, int level)
        {
            return tasks.Where(x => x.Priority.Replace(".", "").Length == level).ToList();
        }

        private List<TaskItem> GetTasksStartingWith(List<TaskItem> tasks, string priority)
        {
            return tasks.Where(x => x.Priority.StartsWith(priority) && x.Priority != priority).ToList();
        }
    }
}