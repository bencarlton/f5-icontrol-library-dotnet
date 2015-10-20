namespace iControl {
	using System.Xml.Serialization;
	using System.Web.Services;
	using System.ComponentModel;
	using System.Web.Services.Protocols;
	using System;
	using System.Diagnostics;

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileRTSPBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileRTSPProfileRTSPStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileRtspProxyType))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfilePortNumber))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileRTSP : iControlInterface {
		public LocalLBProfileRTSP() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void create(
		string [] profile_names
	) {
		this.Invoke("create", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begincreate(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void delete_all_profiles(

	) {
		this.Invoke("delete_all_profiles", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_profiles(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_profiles", new object[0], callback, asyncState);
	}
	public void Enddelete_all_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void delete_profile(
		string [] profile_names
	) {
		this.Invoke("delete_profile", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begindelete_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Enddelete_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileRTSPProfileRTSPStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileRTSPProfileRTSPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileRTSPProfileRTSPStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileRTSPProfileRTSPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_check_source_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_check_source_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_check_source_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_check_source_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_check_source_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_check_source_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_default_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_default_profile", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_idle_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_idle_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_idle_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_idle_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public string [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_log_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_log_profile", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_log_publisher(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_log_publisher", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_publisher(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_publisher", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_header_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_header_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_header_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_header_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_header_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_header_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_queued_data_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_queued_data_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_queued_data_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_queued_data_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_queued_data_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_queued_data_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_multicast_redirect_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_multicast_redirect_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_multicast_redirect_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_multicast_redirect_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_multicast_redirect_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_multicast_redirect_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_header
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_proxy_header(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_proxy_header", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_header(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_header", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_proxy_header(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileRtspProxyType [] get_proxy_type(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_proxy_type", new object [] {
				profile_names});
		return ((LocalLBProfileRtspProxyType [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_type(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_type", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileRtspProxyType [] Endget_proxy_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileRtspProxyType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rtcp_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfilePortNumber [] get_rtcp_port(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_rtcp_port", new object [] {
				profile_names});
		return ((LocalLBProfilePortNumber [])(results[0]));
	}
	public System.IAsyncResult Beginget_rtcp_port(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rtcp_port", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfilePortNumber [] Endget_rtcp_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfilePortNumber [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rtp_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfilePortNumber [] get_rtp_port(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_rtp_port", new object [] {
				profile_names});
		return ((LocalLBProfilePortNumber [])(results[0]));
	}
	public System.IAsyncResult Beginget_rtp_port(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rtp_port", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfilePortNumber [] Endget_rtp_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfilePortNumber [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rtsp_over_http_persistence_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_rtsp_over_http_persistence_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_rtsp_over_http_persistence_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_rtsp_over_http_persistence_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rtsp_over_http_persistence_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_rtsp_over_http_persistence_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_session_reconnect_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_session_reconnect_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_session_reconnect_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_session_reconnect_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_session_reconnect_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_session_reconnect_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileRTSPProfileRTSPStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileRTSPProfileRTSPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileRTSPProfileRTSPStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileRTSPProfileRTSPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStatisticsByVirtual get_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		object [] results = this.Invoke("get_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public LocalLBProfileStatisticsByVirtual Endget_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_unicast_redirect_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_unicast_redirect_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_unicast_redirect_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_unicast_redirect_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_unicast_redirect_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_unicast_redirect_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_version(

	) {
		object [] results = this.Invoke("get_version", new object [] {
});
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_version(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_version", new object[] {
}, callback, asyncState);
	}
	public string Endget_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_base_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_base_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_base_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_base_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_base_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_system_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_system_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_system_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_system_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_system_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_system_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void reset_statistics(
		string [] profile_names
	) {
		this.Invoke("reset_statistics", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginreset_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void reset_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		this.Invoke("reset_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});

	}
	public System.IAsyncResult Beginreset_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public void Endreset_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_check_source_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_check_source_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_check_source_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_check_source_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_check_source_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_check_source_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_default_profile(
		string [] profile_names,
		string [] defaults
	) {
		this.Invoke("set_default_profile", new object [] {
				profile_names,
				defaults});

	}
	public System.IAsyncResult Beginset_default_profile(string [] profile_names,string [] defaults, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_profile", new object[] {
			profile_names,
			defaults}, callback, asyncState);
	}
	public void Endset_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_description(
		string [] profile_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				profile_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] profile_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			profile_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_idle_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_idle_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_idle_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_idle_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_log_profile(
		string [] profile_names,
		LocalLBProfileString [] profiles
	) {
		this.Invoke("set_log_profile", new object [] {
				profile_names,
				profiles});

	}
	public System.IAsyncResult Beginset_log_profile(string [] profile_names,LocalLBProfileString [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_profile", new object[] {
			profile_names,
			profiles}, callback, asyncState);
	}
	public void Endset_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_log_publisher(
		string [] profile_names,
		LocalLBProfileString [] publishers
	) {
		this.Invoke("set_log_publisher", new object [] {
				profile_names,
				publishers});

	}
	public System.IAsyncResult Beginset_log_publisher(string [] profile_names,LocalLBProfileString [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_publisher", new object[] {
			profile_names,
			publishers}, callback, asyncState);
	}
	public void Endset_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_settings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_log_settings(
		string [] profile_names,
		LocalLBProfileString [] publishers,
		LocalLBProfileString [] profiles
	) {
		this.Invoke("set_log_settings", new object [] {
				profile_names,
				publishers,
				profiles});

	}
	public System.IAsyncResult Beginset_log_settings(string [] profile_names,LocalLBProfileString [] publishers,LocalLBProfileString [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_settings", new object[] {
			profile_names,
			publishers,
			profiles}, callback, asyncState);
	}
	public void Endset_log_settings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_header_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_maximum_header_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_maximum_header_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_maximum_header_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_header_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_maximum_header_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_queued_data_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_maximum_queued_data_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_maximum_queued_data_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_maximum_queued_data_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_queued_data_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_maximum_queued_data_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_multicast_redirect_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_multicast_redirect_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_multicast_redirect_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_multicast_redirect_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_multicast_redirect_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_multicast_redirect_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_header
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_proxy_header(
		string [] profile_names,
		LocalLBProfileString [] headers
	) {
		this.Invoke("set_proxy_header", new object [] {
				profile_names,
				headers});

	}
	public System.IAsyncResult Beginset_proxy_header(string [] profile_names,LocalLBProfileString [] headers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_header", new object[] {
			profile_names,
			headers}, callback, asyncState);
	}
	public void Endset_proxy_header(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_proxy_type(
		string [] profile_names,
		LocalLBProfileRtspProxyType [] types
	) {
		this.Invoke("set_proxy_type", new object [] {
				profile_names,
				types});

	}
	public System.IAsyncResult Beginset_proxy_type(string [] profile_names,LocalLBProfileRtspProxyType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_type", new object[] {
			profile_names,
			types}, callback, asyncState);
	}
	public void Endset_proxy_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rtcp_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_rtcp_port(
		string [] profile_names,
		LocalLBProfilePortNumber [] ports
	) {
		this.Invoke("set_rtcp_port", new object [] {
				profile_names,
				ports});

	}
	public System.IAsyncResult Beginset_rtcp_port(string [] profile_names,LocalLBProfilePortNumber [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rtcp_port", new object[] {
			profile_names,
			ports}, callback, asyncState);
	}
	public void Endset_rtcp_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rtp_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_rtp_port(
		string [] profile_names,
		LocalLBProfilePortNumber [] ports
	) {
		this.Invoke("set_rtp_port", new object [] {
				profile_names,
				ports});

	}
	public System.IAsyncResult Beginset_rtp_port(string [] profile_names,LocalLBProfilePortNumber [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rtp_port", new object[] {
			profile_names,
			ports}, callback, asyncState);
	}
	public void Endset_rtp_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rtsp_over_http_persistence_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_rtsp_over_http_persistence_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_rtsp_over_http_persistence_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_rtsp_over_http_persistence_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rtsp_over_http_persistence_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_rtsp_over_http_persistence_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_session_reconnect_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_session_reconnect_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_session_reconnect_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_session_reconnect_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_session_reconnect_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_session_reconnect_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_unicast_redirect_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRTSP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRTSP", ResponseNamespace="urn:iControl:LocalLB/ProfileRTSP")]
	public void set_unicast_redirect_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_unicast_redirect_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_unicast_redirect_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_unicast_redirect_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_unicast_redirect_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileRTSP.ProfileRTSPStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileRTSPProfileRTSPStatisticEntry
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileRTSP.ProfileRTSPStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileRTSPProfileRTSPStatistics
	{
		private LocalLBProfileRTSPProfileRTSPStatisticEntry [] statisticsField;
		public LocalLBProfileRTSPProfileRTSPStatisticEntry [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
		private CommonTimeStamp time_stampField;
		public CommonTimeStamp time_stamp
		{
			get { return this.time_stampField; }
			set { this.time_stampField = value; }
		}
	};

}
