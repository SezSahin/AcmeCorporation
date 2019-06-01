export class Ticket {
    public firstName: string;
    public lasttName: string;
    public email: string;
    public phoneNumber: string;
    public dateOfBirth: string;
    public serialNumber: string;

    constructor(firstName: string, lastName: string, email: string, phoneNumber: string, dateOfBirth: string, serialNumber: string){
        this.firstName = firstName;
        this.lasttName = lastName;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.dateOfBirth = dateOfBirth;
        this.serialNumber = serialNumber;
    }
}
