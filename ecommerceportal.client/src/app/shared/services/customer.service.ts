import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { CustomerRequest, CustomerResponse } from "../models/models";
import { Observable } from "rxjs";


@Injectable({
    providedIn: 'root'
})
export class CustomerService {
    private apiUrl = 'https://localhost:7017/api'
    constructor(private http: HttpClient) {
    }

    public purchaseGroceries(payLoad: CustomerRequest): Observable<boolean> {
        return this.http.post<boolean>(`${this.apiUrl}/customer`, payLoad)
    }

    
    public getCustomerRewardPointsDetails(): Observable<CustomerResponse[]> {
        return this.http.get<CustomerResponse[]>(`${this.apiUrl}/customer`)
    }
}