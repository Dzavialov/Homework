const dataKey = "persons";

function savePerson(person)
{
    var persons = getPersons();

    persons = persons ?? [];

    persons.push(person);

    window.localStorage.removeItem(dataKey);
    window.localStorage.setItem(dataKey, (JSON.stringify(persons)));
}

function getPersons()
{
    return JSON.parse(window.localStorage.getItem(dataKey));
}