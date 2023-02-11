let submitBtn = $("#submitBtn");
let mainForm = $("#mainForm");

function bindFormEnvents()
{
    submitBtn.on('click', function(e) {
        e.preventDefault();

        var personData = convertFormToJSON("#mainForm");
        
        savePerson(personData);
    });
}

bindFormEnvents();