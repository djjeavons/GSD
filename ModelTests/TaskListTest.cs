using System;
namespace ModelTests
{
    public class TaskListTest
    {
        [Fact]
        public void CanInstantiateTaskListAndAllPropertiesAreSetToDefaultValues()
        {
            TaskList newTaskList = new();

            Assert.Equal(0, newTaskList.TaskListId);
            Assert.Null(newTaskList.TaskListName);
            Assert.Null(newTaskList.TaskListDescription);
        }

        [Fact]
        public void CanInstantiateTaskListWithTaskListIdAndOtherPropertiesContainDefaultValues()
        {
            TaskList newTaskList = new() { TaskListId = 1 };

            Assert.Equal(1, newTaskList.TaskListId);
            Assert.Null(newTaskList.TaskListName);
            Assert.Null(newTaskList.TaskListDescription);
        }

        [Fact]
        public void CanInstantiateTaskListWithTaskListNameAndOtherPropertiesContainDefaultValues()
        {
            TaskList newTaskList = new() { TaskListName = "New Task List" };

            Assert.Equal(0, newTaskList.TaskListId);
            Assert.Equal("New Task List", newTaskList.TaskListName);
            Assert.Null(newTaskList.TaskListDescription);
        }

        [Fact]
        public void CanInstantiateTaskListWithTaskListDescriptionAndOtherPropertiesContainDefaultValues()
        {
            TaskList newTaskList = new() { TaskListDescription = "Task List Description" };

            Assert.Equal(0, newTaskList.TaskListId);
            Assert.Null(newTaskList.TaskListName);
            Assert.Equal("Task List Description", newTaskList.TaskListDescription);
        }

        [Fact]
        public void CanInstantiateTaskListWithAllPropertiesSet()
        {
            TaskList newTaskList = new()
            {
                TaskListId = 1,
                TaskListName = "New Task List",
                TaskListDescription = "Task List Description"
            };

            Assert.Equal(1, newTaskList.TaskListId);
            Assert.Equal("New Task List", newTaskList.TaskListName);
            Assert.Equal("Task List Description", newTaskList.TaskListDescription);
        }
    }
}

