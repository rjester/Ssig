class student {
    fullName: string;
    constructor (public firstName, public lastName) {
        this.fullName = firstName + " " + lastName;
    }
}

interface Person {
    firstName: string;
    lastName: string;
}

function greeter(person: Person) {
    return "Hello " + person.firstName + " " + person.lastName;
}

var user = new student("Johnny", "jenkins" );

document.body.innerHTML = greeter(user);