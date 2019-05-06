import org.scalatest.WordSpec

class WorkshopTest extends WordSpec {
  "Workshop" when {
    "created" should {
      "be true" in {
        assert(Workshop.isTrue)
      }
    }
  }
}