using Model;

namespace DL;

public interface IDBRepo
{


    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
    //          Family Member: Bailey
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

    //Ranking system
    public void UpdateRank(Ranking rankToUpdate);

    public List<Ranking> GetAllPlayerRanks();

    public int GetPlayerRank(int playerId);

    public Ranking GetFullRanking(int playerId);

    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_





    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
    //          Family Member: Gianny
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

    //Searching player profile before game 
    public Player GetPlayer(string username);
    public Player GetPlayerbyId(int playerid);

    //Leaderboards
    public List<Player> GetAllPlayers();

    public void UpdatePlayer(Player player);

    //Handles signup
    public Player CreatePlayer(Player playerToCreate);

    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_





    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
    //          Family Member:  Jose
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

    //Piece information
    public Piece GetPiece(int pieceID);
    public List<Piece> GetAllPieces(int boardID);
    public Piece CreatePiece(Piece piece);

    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_





    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_
    //          Family Member:  Donte
    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

    //Board
    public Board GetBoard(int lobbyId);

    public Board CreateBoard(Board boardToCreate);

    public void UpdateBoard(Board boardToUpdate);

    //Create a lobby
    public Lobby CreateLobby(Lobby lobbyToCreate);

    //_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_/~\_

}