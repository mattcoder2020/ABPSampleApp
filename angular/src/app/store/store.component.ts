import { Component, OnInit } from '@angular/core';
import { StoreService } from '@proxy/application-services';
import { ListService, PagedResultDto } from '@abp/ng.core';
import { StoreDto } from '@proxy/dto';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'; 
import { storeStatusOptions } from '@proxy/enums';

@Component({
  selector: 'app-store',
  templateUrl: './store.component.html',
  styleUrls: ['./store.component.scss'],
  providers: [ListService],
})
export class StoreComponent implements OnInit{
  stores = { items: [], totalCount: 0 } as PagedResultDto<StoreDto>;
  form: FormGroup; // add this line

  // add bookTypes as a list of BookType enum members
  StatusTypes = storeStatusOptions;
  selectedStore = {} as StoreDto;


  isModalOpen = false;
  constructor(public readonly list: ListService, private storeService: StoreService, private fb: FormBuilder) 
  {}

  ngOnInit() {
    const storeStreamCreator = (query) => this.storeService.getList(query);

    this.list.hookToQuery(storeStreamCreator).subscribe((response) => {
      this.stores = response;
    });
  }

  createStore() {
    this.buildForm(); // add this line
    this.isModalOpen = true;
  }

  // add buildForm method
  buildForm() {
    this.form = this.fb.group({
      name: ['', Validators.required],
      fullname: [null, Validators.required],
      phone: [null, Validators.required],
      address: [null, Validators.required],
      status:[null, Validators.required]
    });
  }

  // add save method
  save() {
    if (this.form.invalid) {
      return;
    }

    this.storeService.create(this.form.value).subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }
}

