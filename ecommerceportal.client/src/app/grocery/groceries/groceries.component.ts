import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { CustomerService } from '../../shared/services/customer.service';

@Component({
  selector: 'app-groceries',
  templateUrl: './groceries.component.html',
  styleUrl: './groceries.component.css'
})
export class GroceriesComponent implements OnInit {
  groceryForm!: FormGroup;
  public groceryFormArray!: FormArray;

  public constructor(private fb: FormBuilder, private customerService: CustomerService) {

  }

  public get groceriesListForm(): FormArray {
    return this.groceryForm.get('groceries') as FormArray;
  }

  ngOnInit(): void {
    this.groceryForm = this.fb.group({
      groceries: new FormArray([this.createItem]),
      customerName: new FormControl(''),
      customerMobileNumber: new FormControl(''),
      totalAmount: new FormControl({ value: 0, disabled: true })
    });
    this.groceryFormArray = this.groceryForm.get('groceries') as FormArray;
  }

  get createItem(): FormGroup {
    return this.fb.group({
      groceryName: new FormControl(''),
      quantity: new FormControl(0),
      amount: new FormControl(0)
    });
  }

  public amountChange(): void {
    let amount = 0;
    for (let grocery of this.groceryForm.value.groceries) {
      amount = amount + (+grocery.amount)
    }
    this.groceryForm.controls['totalAmount'].setValue(amount);
  }

  public addGrocery(): void {
    this.groceryFormArray.push(this.createItem);
  }

  public removeGrocery(index: number): void {
    this.groceryFormArray.removeAt(index);
  }

  public handleCustomerPurchase(): void {
    this.customerService.purchaseGroceries(this.groceryForm.value).subscribe(
      (response) => {
        this.groceryForm.reset();
      }
    );
  }
}
