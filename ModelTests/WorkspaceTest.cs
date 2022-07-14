using System;
namespace ModelTests
{
    public class WorkspaceTest
    {
        [Fact]
        public void CanInstantiateWorkspaceAndPropertiesContainDefaultValues()
        {
            Workspace newWorkspace = new();

            Assert.Equal(0, newWorkspace.WorkspaceId);
            Assert.Null(newWorkspace.WorkspaceName);
            Assert.Null(newWorkspace.WorkspaceDescription);
        }

        [Fact]
        public void CanInstantiateWorkspaceWithWorkspaceIdAndOtherPropertiesContainDefaultValues()
        {
            Workspace newWorkspace = new() { WorkspaceId = 1 };

            Assert.Equal(1, newWorkspace.WorkspaceId);
            Assert.Null(newWorkspace.WorkspaceName);
            Assert.Null(newWorkspace.WorkspaceDescription);
        }

        [Fact]
        public void CanInstantiateWorkspaceWithWorkspaceNameAndOtherPropertiesContainDefaultValues()
        {
            Workspace newWorkspace = new() { WorkspaceName = "New Workspace Name" };

            Assert.Equal(0, newWorkspace.WorkspaceId);
            Assert.Equal("New Workspace Name", newWorkspace.WorkspaceName);
            Assert.Null(newWorkspace.WorkspaceDescription);
        }

        [Fact]
        public void CanInstantiateWorkspaceWithWorkspaceDescriptionAndOtherPropertiesContainDefaultValues()
        {
            Workspace newWorkspace = new() { WorkspaceDescription = "Workspace Description" };

            Assert.Equal(0, newWorkspace.WorkspaceId);
            Assert.Null(newWorkspace.WorkspaceName);
            Assert.Equal("Workspace Description", newWorkspace.WorkspaceDescription);
        }

        [Fact]
        public void CanInstantiateWorkspaceWithAllPropertiesSet()
        {
            Workspace newWorkspace = new()
            {
                WorkspaceId = 1,
                WorkspaceName = "New Workspace Name",
                WorkspaceDescription = "Workspace Description"
            };

            Assert.Equal(1, newWorkspace.WorkspaceId);
            Assert.Equal("New Workspace Name", newWorkspace.WorkspaceName);
            Assert.Equal("Workspace Description", newWorkspace.WorkspaceDescription);
        }
    }
}

