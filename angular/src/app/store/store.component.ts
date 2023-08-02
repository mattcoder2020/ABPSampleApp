import { Component, OnInit } from '@angular/core';
import { StoreService } from '@proxy/application-services';
import { ListService, PagedResultDto } from '@abp/ng.core';
import { StoreDto } from '@proxy/dto';

@Component({
  selector: 'app-store',
  templateUrl: './store.component.html',
  styleUrls: ['./store.component.scss'],
  providers: [ListService],
})
export class StoreComponent implements OnInit{
  stores = { items: [], totalCount: 0 } as PagedResultDto<StoreDto>;
  constructor(public readonly list: ListService, private storeService: StoreService) {}

  ngOnInit() {
    const storeStreamCreator = (query) => this.storeService.getList(query);

    this.list.hookToQuery(storeStreamCreator).subscribe((response) => {
      this.stores = response;
    });
  }
}

