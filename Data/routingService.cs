using System.Linq;
using System.Threading.Tasks;

namespace BoardWatcherClient
{
    public class RoutingService
    {
        private int gameId;

        public RoutingService()
        {
            gameId = 0;
        }

        public void setGameId(int id)
        {
            gameId = id;
        }

        public int getGameId()
        {
            return gameId;
        }
    }
}
