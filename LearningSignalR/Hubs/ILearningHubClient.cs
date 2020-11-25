using System.Threading.Tasks;

namespace LearningSignalR.Hubs
{
    public interface ILearningHubClient
    {
        Task ReceiveMessage(string message);
    }
}