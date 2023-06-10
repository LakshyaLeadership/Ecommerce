import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-create-inventory',
  templateUrl: './create-inventory.component.html',
  styleUrls: ['./create-inventory.component.css']
})
export class CreateInventoryComponent implements OnInit {
  createInventoryForm: FormGroup | undefined;

  constructor(private fb: FormBuilder) {}

  ngOnInit() {
    this.createInventoryForm = this.fb.group({
      supplierName: ['', Validators.required],
      name: ['', Validators.required],
      sku: ['', Validators.required],
      supplierEmail: ['', [Validators.required, Validators.email]],
      startDate: ['', Validators.required],
      endDate: ['', Validators.required],
      category: ['']
    });
  }

  onSubmit() {
    if (!!this.createInventoryForm && this.createInventoryForm.valid) {
      // Submit the form data to the API
      const formData = this.createInventoryForm.value;
      // Call the API with the form data
      // ...
    }
    console.log(JSON.stringify(this.createInventoryForm.value));
  }
}
