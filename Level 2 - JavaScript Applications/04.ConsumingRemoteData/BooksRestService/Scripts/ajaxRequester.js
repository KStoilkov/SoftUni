var bookApp = bookApp || {};

var AjaxRequester = (function (bookApp) {
	function AjaxRequester() {
		$.ajaxSetup({
			headers: {
				'X-Parse-Application-Id' : 'QKjm2exuBFoR17KtWFXoBfMs71ZZ6ySFgJoGJE1D',
				'X-Parse-REST-API-Key' : 'VkboslURn9Jo75liqB2lYfNTNi3QhPOcFpuq6ya4',
				'Content-Type' : 'application/json'
			}
		});
	}

	AjaxRequester.prototype.getRequest = function (url, success) {
		makeRequest('GET', url, success, null);
	}

	AjaxRequester.prototype.getWhere = function (url, props, success) {
		var url = url + '/?where='+ JSON.stringify(props);
		
		this.getRequest(url, success);
	}

	AjaxRequester.prototype.getById = function (url, id, success) {
		this.getRequest(url + '/' + id, success);
	}

	AjaxRequester.prototype.postRequest = function (url, success, data) {
		makeRequest('POST', url, success, data);
	}

	AjaxRequester.prototype.putRequest = function (url, data, success) {
		makeRequest('PUT', url, success, data);
	}

	AjaxRequester.prototype.deleteRequest = function (url, success) {
		makeRequest('DELETE', url, success, null);
	}

	function makeRequest(method, url, success, data) {
		$.ajax({
			method: method,
			url: url,
			data: data,
			success: success
		});
	}

	bookApp.AjaxRequester = AjaxRequester;
})(bookApp);