  public interface IPersonRepository
    {
        Person GetPersonById(int id);
        void AddPerson(Person person);
        void DeletePerson(int id);
    }
