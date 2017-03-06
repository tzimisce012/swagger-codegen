/**
 * Swagger Petstore
 * This is a sample server Petstore server.  You can find out more about Swagger at <a href=\"http://swagger.io\">http://swagger.io</a> or on irc.freenode.net, #swagger.  For this sample, you can use the api key \"special-key\" to test the authorization filters
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@wordnik.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

import * as models from './models';

export interface Order {
    "id"?: number;
    "petId"?: number;
    "quantity"?: number;
    "shipDate"?: Date;
    /**
     * Order Status
     */
    "status"?: Order.StatusEnum;
    "complete"?: boolean;
}

export namespace Order {
    export enum StatusEnum {
        Placed = <any> 'placed',
        Approved = <any> 'approved',
        Delivered = <any> 'delivered'
    }
}