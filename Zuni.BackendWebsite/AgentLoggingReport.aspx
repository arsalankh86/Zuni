<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniBackend.master" AutoEventWireup="true" CodeFile="AgentLoggingReport.aspx.cs" Inherits="AgentLoggingReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <h3>Agent Logging Report</h3>


      <div class="card-list">

				<div class="app-card">
					<div class="card-header">
						<!-- <i class="fa fa-bars"></i> -->
						<h1>Customer Detail</h1>
					</div>
					<div class="card-body ">
						<div class=""><!--table-responsive-->
							<table class="table table-bordered table-striped ">
								<thead>
									<tr>
										<th class="text-center">
											Agent Detail
										</th>
										<th class="text-center" >
											Address
										</th>
										<th class="text-center">
											Latitude & Longitude
										</th>
                                         <th class="text-center">
											Timing
										</th>
									</tr>
								</thead>
								<tbody class="qty-control">
                                    <asp:Repeater ID="rptAgentLogging" runat="server" >
        
                                    <ItemTemplate>
                                      <tr>
                                          <td><%# Eval("AgentID") %> <br /><%# Eval("Name") %></td>

										<td class="text-center">
											<%# Eval("Address") %> 
										</td>
										<td  class="text-center">
											<%# Eval("Latitude") %> , <%# Eval("Longitude") %>
										</td>
                                         <td  class="text-center">
											<%# Eval("CreatedOn") %>
										</td>
                                           
									</tr>
                                  </ItemTemplate>
                                  </asp:Repeater>
									
								</tbody>							
							</table>
						</div>
					</div>					
				</div>
          </div>

</asp:Content>

