using System;
using System.Collections.Generic;
using System.Text;

namespace SneakerSeekerTest
{
    public void IndexTest()
    {
        //Arrange
        var dbContext = MockDb.CreateMockDb();
        ShopController sc = new ShopController(dbContext);
        //Act
        var r = await sc.Index();
        //Assert
        var result = Assert.IsType<ViewResult>(r);
        var model = Assert.IsAssignableFrom<List<Game>>(result.ViewData.Model);
        Assert.Equal(1, model.Count());
    }




[Fact]
public void TestAddGameToCart()
{
    //Arrange 
    var db = MockDb.CreateMockDb();
    ShopController cc = new ShopController(db);

    var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
        {
                    new Claim(ClaimTypes.Name, "Vy"),
                    new Claim(ClaimTypes.NameIdentifier, "final@test.com"),
        }, "mock"));
    cc.ControllerContext = new ControllerContext()
    {
        HttpContext = new DefaultHttpContext() { User = user }
    };

    //Act

    var r = cc.AddToCart(1);

    //Assert
    var result = Assert.IsType<PartialViewResult>(r);
    Assert.NotNull(db.Users.First().CartId);
    Assert.Equal(1, db.CartItems.Count());
}

[Fact]
public void testTotalCartValueWhenCartIsEmpty()
{
    //Arrange
    var db = MockDb.CreateMockDb();
    var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
        {
                    new Claim(ClaimTypes.Name, "Vy"),
                    new Claim(ClaimTypes.NameIdentifier, "final@test.com"),
        }, "mock"));
    Shop cart = new Shop(db, user);

    //Act

    //Assert
    Assert.Equal(0, cart.total);
}
[Fact]
public void testTotalCartValueWhenCartHasItems()
{
    //Arrange
    var db = MockDb.CreateMockDb();
    var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
        {
                    new Claim(ClaimTypes.Name, "Vy"),
                    new Claim(ClaimTypes.NameIdentifier, "final@test.com"),
        }, "mock"));
    Shop cart = new Shop(db, user);
    cart.addItem(1);
    cart.addItem(1);
    //Act

    //Assert
    Assert.Equal(40, cart.total);
}
    
}