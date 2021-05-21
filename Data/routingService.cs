using System.Linq;
using System.Threading.Tasks;

namespace BoardWatcherClient
{
    public class RoutingService
    {
        private string gameId;

        public RoutingService()
        {
            gameId = "0";
        }

        public void setGameId(string id)
        {
            gameId = id;
        }

        public string getGameId()
        {
            return gameId;
        }
    }
}
