    public class PersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person GetPerson(int id)
        {
            return _personRepository.GetPersonById(id);
        }

        public void CreatePerson(Person person)
        {
            _personRepository.AddPerson(person);
        }

        public void RemovePerson(int id)
        {
            _personRepository.DeletePerson(id);
        }
    }
