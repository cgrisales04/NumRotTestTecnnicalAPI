using NumRotTestTecnnicalAPI.Persistence.Repository.InfoUser;

namespace NumRotTestTecnnicalAPI.Persistence.Repository.Wrapper {
    public interface IRepositoryWrapper {
        IInfoUsersRepository InfoUser { get; }
        void Save();
    }
}
