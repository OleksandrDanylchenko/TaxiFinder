<?xml version="1.0" encoding="utf-8"?>
    <xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
        <xsl:template match="/Taxis">
            <html>

            <head>
                <style>
                    table {
                        border-collapse: collapse;
                    }
                    
                    table, th, td 
					{
                        border: 1px solid black;
                    }
                </style>
            </head>

            <body>
                <table>
                    <tr>
                        <th>Brand</th>
                        <th>Model</th>
                        <th>Color</th>
                        <th>Class</th>
                        <th>Driver</th>
                        <th>Number</th>
                    </tr>
                    <xsl:for-each select="Taxi">
                        <tr>
                            <td>
                                <xsl:value-of select="Brand" />
                            </td>
                            <td>
                                <xsl:value-of select="Model" />
                            </td>
                            <td>
                                <xsl:value-of select="Color" />
                            </td>
                            <td>
                                <xsl:value-of select="Class" />
                            </td>
                            <td>
                                <xsl:value-of select="Driver" />
                            </td>
                            <td>
                                <xsl:value-of select="Number" />
                            </td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>

            </html>
        </xsl:template>
    </xsl:stylesheet>