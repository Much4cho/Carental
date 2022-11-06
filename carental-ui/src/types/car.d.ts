interface Car {
    id: string;
    description: string;
    manufacturer: string;
    model: string
    modelYear: number;
    color: string;
    capacity: number;
    plateNumber: string;
    renterId: string;
    pricePerMinute: number;
    pricePerKilometer: number;
    parkedPricePerMinute: number;
    location: Location;
    renter: Renter;
}