import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  title = 'eCommerce';
  items: MenuItem[] | undefined;
  public constructor(private router: Router) { }

  ngOnInit() {
    this.items = [
      {
        label: 'Purchase',
        icon: 'pi pi-home',
        command: () => {
          this.router.navigate(['/grocery']);
        }
      },
      {
        label: 'Customer Details',
        icon: 'pi pi-star',
        command: () => {
          this.router.navigate(['/grocery/customer-rewards']);
        }
      }
    ]
  }
}
