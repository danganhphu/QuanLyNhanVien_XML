<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:xs="http://www.w3.org/2001/XMLSchema"
    exclude-result-prefixes="xs"
    version="2.0">
    <xsl:template match="/congty">
        <html>
            <body>
                <table border="1">
                    <tr>
                        <th>Mã nv</th>
                        <th>Họ tên</th>
                        <th>lương</th>
                        <th>tên phòng ban</th>
                        <th>số đt</th>
                    </tr>
                    <xsl:for-each select="nhanvien">
                        <tr>
                            <td><xsl:value-of select="@manv"/></td>
                            <td><xsl:value-of select="hoten"/></td>
                            <td><xsl:value-of select="luong"/></td>
                            <td><xsl:value-of select="phongban/tenphong"/></td>
                            <td><xsl:value-of select="phongban/dienthoai"/></td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>