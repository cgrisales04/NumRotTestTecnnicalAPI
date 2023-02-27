using NumRotTestTecnnicalAPI.Persistence.Entity;

namespace NumRotTestTecnnicalAPI.Persistence.Repository.InfoUser {
    public interface IInfoUsersRepository {
        IEnumerable<InfoUsers> GetAllInfoUsers();
        InfoUsers GetInfoUsersById(int id);
        InfoUsers GetInfoUsersByIdNotJoin(int id);
        InfoUsers GetInfoUsersByIdentification(string identification);

        void CreateInfoUsers(InfoUsers infoUsers);

        void UpdateInfoUsers(InfoUsers infoUsers);
        void DeleteInfoUsers(InfoUsers infoUsers);

    }
}
