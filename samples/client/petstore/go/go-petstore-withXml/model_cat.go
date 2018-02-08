/*
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * API version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */

package petstore

type Cat struct {
	ClassName string `json:"className" xml:"className"`

	Color string `json:"color,omitempty" xml:"color"`

	Declawed bool `json:"declawed,omitempty" xml:"declawed"`
}
