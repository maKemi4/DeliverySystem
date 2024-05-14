export class DeliveryRequestCreateModel{
    contactInformation: ContactInformation = new ContactInformation();
    requirements: Requirements = new Requirements();
}

class ContactInformation {
    customerName: string;
    customerSurname: string;
    email: string;
    phoneNum: string;
    localityName: string;
    latitude: number;
    longtitude: number;
}

class Requirements {
    numOfVictims: number;
    numOfSeveralyVictims: number;
    conditionType: number = 0;
    situationDescription: string;
    importance: number = 0;
    ageGroup: number = 0;
    neededSpecialist: number = 0;
}