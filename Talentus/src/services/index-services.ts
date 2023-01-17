import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { FormModel } from "src/models/form-Model";
import { ServiceControl } from "./service-control";

@Injectable({
    providedIn: 'root'
  })

export class IndexServices {

    /**
     *
     */
    constructor(private service: ServiceControl) {
            
    }
  manageForm(model: any) : Observable<any> {
    return this.service.post('https://localhost:44337/api/Email', model);
  }

}