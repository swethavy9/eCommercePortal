import { Component, OnInit } from '@angular/core';
import { CustomerService } from '../shared/services/customer.service';
import { CustomerResponse, TransactionResponse } from '../shared/models/models';

@Component({
  selector: 'app-customer-details',
  templateUrl: './customer-details.component.html',
  styleUrl: './customer-details.component.css'
})
export class CustomerDetailsComponent implements OnInit {
  customerRewarPoints!: CustomerResponse[];
  public transactions!: TransactionResponse[];
  visible = false;
  constructor(private cs: CustomerService) {
    this.cs.getCustomerRewardPointsDetails().subscribe((data) => {
      this.customerRewarPoints = data;
    });
  }

  ngOnInit() {

  }

  public transactionDetails(transactions: TransactionResponse[]) {
    this.transactions = transactions;
    this.visible = true;
  }
}
