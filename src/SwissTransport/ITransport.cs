
using System.Threading.Tasks;
namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStattion, string date, string time);
        object GetConnections(string v1, string v2);
    }
}