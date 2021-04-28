# WcfService Duplex Callbacks

## Web.config

Set attribute binding of tag endpoint to **wsDualHttpBinding**.

Set attribute contract of tag endpoint to *"yourNamespace.yourServiceInterface"*

Set attribute baseAddress of tag add to *"http:// localhost:8090 /yourNameSpace/YourSCVfile/"*

```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
   <system.serviceModel>
      <behaviors>
         <serviceBehaviors>
            <behavior name="">
               <serviceMetadata httpGetEnabled="true" />
               <serviceDebug includeExceptionDetailInFaults="false" />
            </behavior>
         </serviceBehaviors>
      </behaviors>
      <services>
         <service name="Service.Service">
            <endpoint address="" binding="wsDualHttpBinding" contract="Service.IService">
               <identity>
                  <dns value="localhost"/>
               </identity>
            </endpoint>
            <endpoint address="mex" binding="mexHttpBinding" contract="IMetadataExchange" />
            <host>
               <baseAddresses>
                  <add baseAddress="http://localhost:8090/Service/Service/" />
               </baseAddresses>
            </host>
         </service>
      </services>
   </system.serviceModel>
</configuration>
```
