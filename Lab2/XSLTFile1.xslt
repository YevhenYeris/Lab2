<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="html"/>
  
    <xsl:template match="Collection">
      <html>
        <body>
          <table border ="1">

            <TR>
              <th>Country</th>
              <th>Type</th>
              <th>Year</th>
              <th>Value</th>
              <th>CurrencyUnit</th>
              <th>Shape</th>
              <th>Composition</th>
              <th>Edge</th>
              <th>Theme</th>
            </TR>
                <xsl:for-each select="//Coin">
                  <tr>
                    <td>
                      <xsl:value-of select="ancestor::Country[1]/@ID"/>
                    </td>
                    <td>
                      <xsl:value-of select="@Type"/>
                    </td>
                    <td>
                      <xsl:value-of select="@Year"/>
                    </td>
                    <td>
                      <xsl:value-of select="@Value"/>
                    </td>
                    <td>
                      <xsl:value-of select="@CurrencyUnit"/>
                    </td>
                    <td>
                      <xsl:value-of select="@Shape"/>
                    </td>
                    <td>
                      <xsl:value-of select="@Composition"/>
                    </td>
                    <td>
                      <xsl:value-of select="@Edge"/>
                    </td>
                    <td>
                      <xsl:value-of select="@Subject"/>
                    </td>
                  </tr>
                </xsl:for-each>
          </table>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
