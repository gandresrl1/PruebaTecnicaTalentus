import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
    providedIn: "root",
  })

export class ServiceControl{
    /**
     *
     */
    constructor(private http: HttpClient,) {

    }

    post(service: string, params: any): Observable<any> {
        let reqOptions: any = {
          params: params,
          withCredentials: true
        };
    
        return this.http.post<any>(service, null, reqOptions);
      }

}