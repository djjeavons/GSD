namespace ModelTests;

public class ProjectTest
{
    [Fact]
    public void CanInstantiateProjectAndPropertiesAreSetToDefaultValues()
    {
        Project newProject = new();

        Assert.Equal(0, newProject.ProjectId);
        Assert.Null(newProject.ProjectTitle);
        Assert.Null(newProject.ProjectDescription);
    }

    [Fact]
    public void CanInstantiateProjectWithProjectIdAndOtherPropertiesContainDefaultValues()
    {
        Project newProject = new() { ProjectId = 1 };

        Assert.Equal(1, newProject.ProjectId);
        Assert.Null(newProject.ProjectTitle);
        Assert.Null(newProject.ProjectDescription);
    }

    [Fact]
    public void CanInstantiateProjectWithProjectTitleAndOtherPropertiesContainDefaultValues()
    {
        Project newProject = new() { ProjectTitle = "New Project Title" };

        Assert.Equal(0, newProject.ProjectId);
        Assert.Equal("New Project Title", newProject.ProjectTitle);
        Assert.Null(newProject.ProjectDescription);
    }

    [Fact]
    public void CanInstantiateProjectWithProjectDescriptionAndOtherPropertiesContainDefaultValues()
    {
        Project newProject = new() { ProjectDescription = "Project Description" };

        Assert.Equal(0, newProject.ProjectId);
        Assert.Null(newProject.ProjectTitle);
        Assert.Equal("Project Description", newProject.ProjectDescription);
    }

    [Fact]
    public void CanInstantiateProjectWithAllPropertiesSet()
    {
        Project newProject = new()
        {
            ProjectId = 1,
            ProjectTitle = "New Project Title",
            ProjectDescription = "Project Description"
        };

        Assert.Equal(1, newProject.ProjectId);
        Assert.Equal("New Project Title", newProject.ProjectTitle);
        Assert.Equal("Project Description", newProject.ProjectDescription);
    }
}
